import { Injectable } from '@angular/core';
import { environment } from '../environments/environment.development';
import { HttpClient, HttpHeaders } from '@angular/common/http';
import { Observable } from 'rxjs';

const PathUrl = environment.root + '/api/';
const httpOptions = {
  headers: new HttpHeaders({ 'Content-Type': 'application/json' })
}

@Injectable({
  providedIn: 'root'
})

export class AppService {
  constructor(private http: HttpClient) { }

  public RegistraRegistro(registro: any): Observable<any> {
    const url = PathUrl + `RegistraRegistro`;
    return this.http.post<any>(url, registro, httpOptions);
  }

  public Registros(): Observable<Array<any>> {
    const url = PathUrl + `Registros`;
    return this.http.get<Array<any>>('https://localhost?7130/api/Registro');
  }
}
