namespace VehiculosYa.Common;
public interface ICRUD<I, O>
{
    List<O> GetAll();
    O GetById(Guid id);
    O Create(I obj);
    O Update(I obj, Guid id);
    void Delete(Guid id);
}