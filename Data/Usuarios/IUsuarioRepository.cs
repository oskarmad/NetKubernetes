using NetKubernetes.Dtos.UsuarioDtos;

namespace NetKubernetes.Data.Usuarios;


public interface IUsuarioRepository {

    Task<UsuarioResponseDto> GetUsuario();

    Task<UsuarioResponseDto> Login(UsuarioLoginRequestDto request);

    Task<UsuarioResponseDto> RegistroUsuario(UsuarioRegistroRequestDto request);
}