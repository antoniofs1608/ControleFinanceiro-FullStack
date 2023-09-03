import { ReactiveFormsModule } from '@angular/forms';
import { FormsModule } from '@angular/forms';

import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';
import { HttpClientModule } from '@angular/common/http';
import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';

import { TiposService } from './services/tipos.service';
import { CategoriasService } from './services/categorias.service';
import { FuncoesService } from './services/funcoes.service';
import { UsuariosService } from './services/usuarios.service';
import { AuthGuardService } from './services/auth-guard.service';
import { CartoesService } from './services/cartoes.service';
import { MesService } from './services/mes.service';
import { DespesasService } from './services/despesas.service';
import { DashboardService } from './services/dashboard.service';

import { ListagemCategoriasComponent, DialogExclusaoCategoriasComponent } from './components/Categoria/listagem-categorias/listagem-categorias.component';
import { AtualizarCategoriaComponent } from './components/Categoria/atualizar-categoria/atualizar-categoria.component';
import { NovaCategoriaComponent } from './components/Categoria/nova-categoria/nova-categoria.component';

import { BrowserAnimationsModule } from '@angular/platform-browser/animations';
import { MatTableModule } from '@angular/material/table';
import { MatIconModule} from '@angular/material/icon';
import { MatButtonModule } from '@angular/material/button';
import { MatCardModule} from '@angular/material/card';
import { MatFormFieldModule} from '@angular/material/form-field';
import { MatInputModule } from '@angular/material/input';
import { MatDividerModule} from '@angular/material/divider';
import { MatSelectModule } from '@angular/material/select';
import { MatGridListModule } from '@angular/material/grid-list';
import { MatDialogModule } from '@angular/material/dialog';
import { MatAutocompleteModule } from '@angular/material/autocomplete';
import { MatPaginatorModule} from '@angular/material/paginator';
import { MatSortModule } from '@angular/material/sort';
import { MatSnackBarModule } from '@angular/material/snack-bar';
import { MatProgressBarModule } from '@angular/material/progress-bar';
import { MatSidenavModule } from '@angular/material/sidenav';
import { MatListModule } from '@angular/material/list';
import { MatToolbarModule } from '@angular/material/toolbar';

import { ListagemFuncoesComponent } from './components/Funcao/listagem-funcoes/listagem-funcoes.component';
import { NovaFuncaoComponent } from './components/Funcao/nova-funcao/nova-funcao.component';
import { AtualizarFuncaoComponent } from './components/Funcao/atualizar-funcao/atualizar-funcao.component';
import { RegistrarUsuarioComponent } from './components/Usuario/Registro/registrar-usuario/registrar-usuario.component';
import { LoginUsuarioComponent } from './components/Usuario/Login/login-usuario/login-usuario.component';
import { DashboardComponent } from './components/Dashboard/dashboard/dashboard.component';
import { HeaderComponent } from './components/Dashboard/header/header.component';
import { NovoCartaoComponent } from './components/Cartao/novo-cartao/novo-cartao.component';
import { ListagemCartoesComponent  } from './components/Cartao/listagem-cartoes/listagem-cartoes.component';
import { AtualizarCartaoComponent } from './components/Cartao/atualizar-cartao/atualizar-cartao.component';
import { IndexComponent } from './components/Dashboard/index/index.component';
import { AtualizarDespesaComponent } from './components/Despesa/atualizar-despesa/atualizar-despesa.component';
import { ListagemDespesasComponent } from './components/Despesa/listagem-despesas/listagem-despesas.component';
import { NovaDespesaComponent } from './components/Despesa/nova-despesa/nova-despesa.component';
import { AtualizarGanhoComponent } from './components/Ganho/atualizar-ganho/atualizar-ganho.component';
import { ListagemGanhosComponent } from './components/Ganho/listagem-ganhos/listagem-ganhos.component';
import { NovoGanhoComponent } from './components/Ganho/novo-ganho/novo-ganho.component';
import { AtualizarUsuarioComponent } from './components/Usuario/atualizar-usuario/atualizar-usuario.component';




@NgModule({
  declarations: [
    AppComponent,
    ListagemCategoriasComponent,
    NovaCategoriaComponent,
    AtualizarCategoriaComponent,
    DialogExclusaoCategoriasComponent,
    ListagemFuncoesComponent,
    NovaFuncaoComponent,
    AtualizarFuncaoComponent,
    RegistrarUsuarioComponent,
    LoginUsuarioComponent,
    DashboardComponent,
    HeaderComponent,
    NovoCartaoComponent,
    ListagemCartoesComponent,
    AtualizarCartaoComponent,
    NovaDespesaComponent,
    ListagemDespesasComponent,
    AtualizarDespesaComponent,
    NovoGanhoComponent,
    ListagemGanhosComponent,
    AtualizarGanhoComponent,
    AtualizarUsuarioComponent,
    IndexComponent,
    ListagemCartoesComponent,
  ],
  imports: [
    BrowserModule,
    AppRoutingModule,
    FormsModule, 
    BrowserAnimationsModule, MatTableModule, MatIconModule, MatButtonModule,
    HttpClientModule, MatCardModule, MatFormFieldModule, MatGridListModule,
    MatInputModule, MatDividerModule, MatSelectModule,  ReactiveFormsModule,
    MatDialogModule, MatAutocompleteModule, MatPaginatorModule, MatSnackBarModule, 
    MatSortModule, MatProgressBarModule, MatSidenavModule, MatListModule, MatToolbarModule
  ],
  providers: [
    TiposService,
    CategoriasService,
    FuncoesService,
    HttpClientModule,
    UsuariosService,
    CartoesService,
    AuthGuardService,
    DespesasService,
    DashboardService,
    MesService
  ],
  bootstrap: [AppComponent]
})
export class AppModule { }
