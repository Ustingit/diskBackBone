namespace DiscountPoolBackbone.SocialNetworsHandling
{
    public interface IParse
    {
        int GetLikesCount();
        int GetCommentsCount();
        decimal GetCommentInvolvementRate();
        ParsingResult GetFullParsingResult();
        //TODO: add getimage, getimages etc
    }
}
