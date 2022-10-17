import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';
import { environment } from 'src/environments/environment';

@Injectable({
  providedIn: 'root'
})
export class ApiService {

  constructor(private http: HttpClient) { }

  get<T>(endpoint: string, options = {}): Observable<T> {
    let url = `${environment.baseUrl}/${endpoint}`;
    return this.http.get<T>(url, options);
  }
}
