namespace PortfolioWebsite.Client.Shared
{
    public class ScrollLinkData
    {
        public string ScrollAnchorId { get; set; }
        public string DisplayText { get; set; }

        public ScrollLinkData(string displayText, string scrollAnchorId)
        {
            DisplayText = displayText;
            ScrollAnchorId = scrollAnchorId;
        }
    }
}
