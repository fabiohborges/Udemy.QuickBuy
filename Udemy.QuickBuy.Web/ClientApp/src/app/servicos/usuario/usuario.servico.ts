import { Injectable, Inject } from "@angular/core"
import { HttpClient, HttpHeaders } from "@angular/common/http"
import { Observable } from "rxjs"
import { Usuario } from "src/app/model/usuario";

@Injectable({
  providedIn: "root"
})

export class UsuarioServico {

  private baseURL: string;
  constructor(private http: HttpClient, @Inject('BASE_URL') baseUrl: string) {
    this.baseURL = baseUrl;
  }

  public verificaUsuario(usuario: Usuario): Observable<Usuario> {

    const headers = new HttpHeaders().set('content-type', 'application/json');

    var body = {
      email: usuario.email,
      senha: usuario.senha
    }

    //this.baseURL = raiz do site que pode ser por exemplo: http://www.quickbuy.com
    return this.http.post<Usuario>(this.baseURL + "api/usuario", body, { headers });

  }

}
