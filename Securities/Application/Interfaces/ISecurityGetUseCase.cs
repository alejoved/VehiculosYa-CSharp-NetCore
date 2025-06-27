namespace VehiculosYa.Securities.Application.Interfaces;
public interface ISecurityGetUseCase
{
    public List<Security> Execute(Security security);
}