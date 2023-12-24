using Accord.MachineLearning;
using Microsoft.Win32;
using OxyPlot;
using OxyPlot.Series;
using OxyPlot.Wpf;
using System;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;

namespace SalesAnalysis;

public class ClusterAnalysisViewModel : INotifyPropertyChanged
{
    public ClusterAnalysisViewModel()
    {
        PlotCollection = new PlotModel { Title = "Кластеризация вакансий" };
        PlotCollection.Background = OxyColors.White;

        using (var db = new SalesAnalysisContext())
        {
            Products = new ObservableCollection<Product>(db.Products);
        }
    }

    public ObservableCollection<ClusteredProduct> ClusteredProducts { get; set; } = new ObservableCollection<ClusteredProduct>();


    private ObservableCollection<Product> _Products;
    public ObservableCollection<Product> Products
    {
        get { return _Products; }
        set
        {
            if (_Products != value)
            {
                _Products = value;
                OnPropertyChanged("Products");
            }
        }
    }


    private PlotModel _PlotCollection;
    public PlotModel PlotCollection
    {
        get { return _PlotCollection; }
        set
        {
            if (_PlotCollection != value)
            {
                _PlotCollection = value;
                OnPropertyChanged("PlotCollection");
            }
        }
    }

    private RelayCommand _SavePlotCommand;
    public RelayCommand SavePlotCommand
    {
        get
        {
            return _SavePlotCommand ?? (_SavePlotCommand = new RelayCommand(param =>
            {
                var plotView = param as PlotView;
                SavePlotAsPng(plotView);
            }));
        }
    }

    private void SavePlotAsPng(PlotView plotView)
    {
        var dialog = new SaveFileDialog()
        {
            Filter = "PNG Files (*.png)|*.png",
            DefaultExt = ".png",
            AddExtension = true
        };
        if (dialog.ShowDialog() == true)
        {
            string fileName = dialog.FileName;
            var pngExporter = new OxyPlot.Wpf.PngExporter { Width = 600, Height = 400 };

            using (var fileStream = new FileStream(fileName, FileMode.Create))
            {
                pngExporter.Export(plotView.Model, fileStream);
            }
        }
    }
    private RelayCommand _LoadClusterAnalysisWindowCommand;
    public RelayCommand LoadClusterAnalysisWindowCommand
    {
        get
        {
            return _LoadClusterAnalysisWindowCommand ??
              (_LoadClusterAnalysisWindowCommand = new RelayCommand(obj =>
              {
                  using (var db = new SalesAnalysisContext())
                  {
                      // 1. Получение данных о средней зарплате и времени закрытия вакансии
                      var rawData = db.Products.ToList();

                      // 2. Нормализация данных
                      double maxPrice = rawData.Max(r => Convert.ToDouble(r.Price));
                      double maxTotal = rawData.Max(r => r.Total);

                      var normalizedData = rawData.Select(r => new[]
                      {
                          r.Price / maxPrice,
                          r.Total / maxTotal
                      }).ToList();

                      // 3. Заполнение массива observations
                      double[][] observations = normalizedData
                           .Select(r => r.Select(val => val).ToArray())
                           .ToArray();

                      //k-means кластеризация

                      // Задаем количество кластеров
                      int clusterCount = 4;
                      var kmeans = new KMeans(clusterCount)
                      {
                          //Distance = new SquareEuclidean(),
                          //Tolerance = 0.05
                      };
                      //                          double[][] initialCentroids =
                      //                          {
                      //    new[] {0.0, 0.0},  // Левый нижний угол
                      //    new[] {1.0, 0.0},  // Правый нижний угол
                      //    new[] {0.0, 1.0},  // Левый верхний угол
                      //    new[] {1.0, 1.0},  // Правый верхний угол
                      //    new[] {0.5, 0.5}   // Центр
                      //};
                      //                          kmeans.Clusters.Centroids = initialCentroids;
                      // Выполняем кластеризацию
                      var clusters = kmeans.Learn(observations);

                      int[] labels = clusters.Decide(observations);

                      ClusteredProducts.Clear();
                      for (int i = 0; i < rawData.Count; i++)
                      {
                          ClusteredProducts.Add(new ClusteredProduct
                          {
                              Id = rawData[i].Id,
                              Price = rawData[i].Price,
                              NormalizedPrice = normalizedData[i][0],
                              Total = rawData[i].Total,
                              NormalizedTotal = normalizedData[i][1],
                              AssignedCluster = labels[i],
                              Name = rawData[i].Name
                          });
                      }

                      var groupedByCluster = observations.Zip(labels, (observation, label) => new { observation, label })
                               .GroupBy(ol => ol.label)
                               .ToList();

                      //OnPropertyChanged(nameof(PlotModel));
                      var clusterColors = new[]
                      {
                          OxyColors.Red,
                          OxyColors.Black,
                          OxyColors.Green,
                          OxyColors.Blue,
                          OxyColors.Yellow
                      };

                      foreach (var clusterGroup in groupedByCluster)
                      {
                          var series = new ScatterSeries
                          {
                              MarkerType = MarkerType.Circle,
                              MarkerSize = 4,
                              MarkerFill = clusterColors[clusterGroup.Key] // Установите цвет на основе метки кластера

                          };

                          foreach (var item in clusterGroup)
                          {
                              double x = item.observation[0] * maxPrice; // Денормализация данных
                              double y = item.observation[1] * maxTotal; // Денормализация данных
                              series.Points.Add(new ScatterPoint(x, y));
                          }

                          AddSeriesToPlot(_PlotCollection, series);
                      }

                      OnPropertyChanged("PlotCollection");
                      PlotCollection.InvalidatePlot(true);
                  }
              }));
        }
    }
    private void AddSeriesToPlot(PlotModel plotModel, ScatterSeries series)
    {
        plotModel.Series.Add(series);
        OnPropertyChanged("PlotCollection");
    }



    public event PropertyChangedEventHandler PropertyChanged;
    public void OnPropertyChanged([CallerMemberName] string prop = "")
    {
        if (PropertyChanged != null)
            PropertyChanged(this, new PropertyChangedEventArgs(prop));
    }
}
