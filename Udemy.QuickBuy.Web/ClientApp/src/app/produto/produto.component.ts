import { Component } from "@angular/core";

@Component({
  selector: "produto",
  templateUrl: "./produto.component.html",
  styleUrls: [
    "./produto.component.css"
  ]
})
export class ProdutoComponent {
  id: number;
  public nome: string;
  public liberadoParaVenda: boolean;

  public obterNome(): string {
    return "samsung";
  }
}
