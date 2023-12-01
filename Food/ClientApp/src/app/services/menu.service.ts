import { HttpClient } from '@angular/common/http';
import { Inject, Injectable } from '@angular/core';
import { Observable } from 'rxjs';
import { Menu } from '../models/menu';

@Injectable({
  providedIn: 'root'
})
export class MenuService {

  constructor(private http:HttpClient, @Inject('BASE_URL') private baseUrl: string) { }

  GetFoods():Observable<Menu[]>{
    return this.http.get<Menu[]>(`${this.baseUrl}menu/getFoods`);
  }

  GetName(name:string):Observable<Menu>{
    return this.http.get<Menu>(`${this.baseUrl}menu/${name}`);
  }

  DeleteName(name: string):Observable<Menu>{
    return this.http.delete<Menu>(`${this.baseUrl}menu/name?=${name}`);
  }

}
