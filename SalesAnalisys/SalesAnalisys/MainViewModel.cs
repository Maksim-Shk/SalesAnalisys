using SalesAnalysis;

namespace SalesAnalysis;

public class MainViewModel
{
    public ClusterAnalysisViewModel ClusterAnalysisViewModel { get; set; }

    public MainViewModel()
    {
        ClusterAnalysisViewModel = new ClusterAnalysisViewModel();
    }
}
