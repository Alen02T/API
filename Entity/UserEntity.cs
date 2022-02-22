using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

[Table("User")]
public class UserEntity
{

    [MaxLength(50)]

    
    public string Nombre { get; set; }
[MaxLength(50)]
    public string Apellido { get; set; }
    public DateTime? FechaNacimiento { get; set; }
    public int Id { get; set; }

}
