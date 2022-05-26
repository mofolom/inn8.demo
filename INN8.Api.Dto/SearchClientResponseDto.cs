namespace INN8.Api.Dto
{
  public class SearchClientResponseDto
  {
    private object clientInfo;
    private object accInfo;

    public SearchClientResponseDto(object clientInfo, object accInfo)
    {
      this.clientInfo = clientInfo;
      this.accInfo = accInfo;
    }

    public SearchClientResponseDto()
    {

    }
  }
}
