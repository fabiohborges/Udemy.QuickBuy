import { Component, OnInit } from "@angular/core";
import { Usuario } from "../../model/usuario";
import { Router, ActivatedRoute } from "@angular/router"
import { UsuarioServico } from "src/app/servicos/usuario/usuario.servico";

@Component({
  selector: "app-login",
  templateUrl: "./login.component.html",
  styleUrls:["./login.component.css"]
})

export class LoginComponent implements OnInit {
  public usuario;
  public usuarioAutenticado: boolean;
  public senhaIncorreta: boolean;
  public usuarios = ["usuario1", "usuario2", "usuario3", "usuario4", "usuario5"];
  public returnUrl: string;

  constructor(private router: Router, private activatedRouter: ActivatedRoute,
                private usuarioServico: UsuarioServico) {
  }

  ngOnInit(): void {
    //localStorage.removeItem("usuario-autenticado");
    this.usuario = new Usuario();
    this.returnUrl = this.activatedRouter.snapshot.queryParams['returnUrl'];
  }

  public enderecoImagem = "data:image/png;base64,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";
  public titulo = "Título adicionado no componente";

  entrar() {

    this.usuarioServico.verificaUsuario(this.usuario)
      .subscribe({
        data => {

        },
        err => {

        }
      });
    //if (this.usuario.email == "fabiohborges@gmail.com" && this.usuario.senha == "1234") {
    //  //localStorage.setItem("usuario-autenticado", "1")
    //  sessionStorage.setItem("usuario-autenticado", "1");
    //  //this.router.navigate(['/']);
    //  if (this.returnUrl != undefined) {
    //    this.router.navigate([this.returnUrl]);
    //  } else {
    //    this.router.navigate(['/']);
    //  }
      
    //  this.usuarioAutenticado = true;
    //  this.senhaIncorreta = false;
    //} else {
    //  this.senhaIncorreta = true;
    //}
    ////alert(this.usuario.email + " - " + this.usuario.senha)
  }
}
