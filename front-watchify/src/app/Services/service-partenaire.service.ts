import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Film } from '../Models/Film';
import { Observable } from 'rxjs';

@Injectable({
  providedIn: 'root'
})
export class ServicePartenaireService {

  constructor(private http:HttpClient) { }

  private url="https://localhost:7178/api/Film/"
  private urlcom="https://localhost:7178/api/Commantaire/"


  GetAllFilm(){
    return this.http.get(this.url+"all")
  }

  GetFilmParIdUser(id:number)
  {
    return this.http.get(this.url+"user/"+id)
  }

  GetLogoFilePathByUserId(id:number){
    return this.http.get(this.url+"logo/"+id)

  }
  getLogoFile(id: string) {
    return this.http.get(`${this.url}logo/${id}`);
  }

  getvedio(namevedio:string){
   return this.http.get(this.url+"vedio/"+namevedio)
  }
  AjouterFilm(film:FormData)
  {
    return this.http.post(this.url+"AddFilm",film)
  }

  GetFilmparId(id:number):Observable<Film>
  {
    return this.http.get<Film>(`${this.url}${id}`);
  }


  GetCommantairebaridfilm(id:number){
    return this.http.get(this.urlcom+"film/"+id)
  }


}
