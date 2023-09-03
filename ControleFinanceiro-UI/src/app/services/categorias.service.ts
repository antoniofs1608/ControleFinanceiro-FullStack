import { HttpClient, HttpHeaders } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Categoria } from './../models/Categoria';
import { Observable} from 'rxjs';

const httpOptions = {
headers: new HttpHeaders({
  'Content-Type': 'application/json',
  'Authorization': `Bearer ${localStorage.getItem('TokenUsuarioLogado')}`
}),
};

@Injectable({
  providedIn: 'root'
})
export class CategoriasService {
  url = 'api/categorias';
  
  constructor(private http: HttpClient) {}
  
  PegarTodos(): Observable<Categoria[]>{
    return this.http.get<Categoria[]>(this.url);
  }

  /* Usar aspa invertida
     No caso abaixo vai fiar api/Categoria/Id
     Exemplo: api/Categoria/4  */
  PegarCategoriaPeloId(categoriaId: number) : Observable<Categoria>{
    const apiUrl = `${this.url}/${categoriaId}`;
    return this.http.get<Categoria>(apiUrl);
  }

 /* Inserir uma nova categoria no banco de dados 
    Vamos retornar um tipo de dado que não vai ser definido aqui, ou seja,
    Observable<any> vai ser definido em tempo de execução. */
  NovaCategoria(categoria: Categoria) : Observable<any>{
    console.log(localStorage.getItem('TokenUsuarioLogado'));
    return this.http.post<Categoria>(this.url, categoria, httpOptions);
  }

  AtualizarCategoria(categoriaId: number, categoria: Categoria) : Observable<any>{
    const apiUrl = `${this.url}/${categoriaId}`;
    return this.http.put<Categoria>(apiUrl, categoria, httpOptions);
  }

 /* Para excluir uma Categoria precisamos do Id 
    Será retornado algo que desconhecemos Observable */
  ExcluirCategoria (categoriaId: number) : Observable<any>{
    const apiUrl = `${this.url}/${categoriaId}`;
    return this.http.delete<number>(apiUrl, httpOptions);
  }

  FiltrarCategorias (nomeCategoria: string) : Observable<Categoria[]>{
    const apiUrl = `${this.url}/FiltrarCategorias/${nomeCategoria}`;
    return this.http.get<Categoria[]>(apiUrl);
  }

  FiltrarCategoriasDespesas(): Observable<Categoria[]>{
    const apiUrl = `${this.url}/FiltrarCategoriasDespesas`;
    return this.http.get<Categoria[]>(apiUrl);
  }
  
  FiltrarCategoriasGanhos(): Observable<Categoria[]>{
    const apiUrl = `${this.url}/FiltrarCategoriasGanhos`;
    return this.http.get<Categoria[]>(apiUrl);
  }  
}


