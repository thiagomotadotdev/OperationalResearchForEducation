import { Injectable } from '@angular/core';
import { HttpHeaders, HttpClient } from '@angular/common/http';
import { Observable } from 'rxjs';
import { environment } from '../../environments/environment';

@Injectable({
  providedIn: 'root'
})
export abstract class BaseService {
  private apiUrl: string;

  httpOptions = {
    headers: new HttpHeaders({
      'content-type': 'application/json',
    })
  };

  constructor(
    private httpClient: HttpClient,
  ) {
    this.apiUrl = `${environment.apiBaseUrl}${this.getApiPath()}`;
  }

  protected get<TResult>(subPath: string): Observable<TResult> {
    return this.httpClient.get(`${this.apiUrl}${subPath}`, this.httpOptions) as Observable<TResult>;
  }

  protected post<TRequest, TResponse>(subPath: string, model: TRequest): Observable<TResponse> {
    return this.httpClient.post<TResponse>(`${this.apiUrl}${subPath}`, JSON.stringify(model), this.httpOptions);
  }

  protected abstract getApiPath(): string;
}
