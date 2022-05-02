import { Injectable } from '@angular/core';
import {HttpClient} from "@angular/common/http";
import {Observable} from "rxjs";
import {Team} from "../../models/team.model";

@Injectable({
  providedIn: 'root'
})
export class TeamsService {

  baseUrl = "https://localhost:7020/api/Teams";

  constructor(private http: HttpClient) { }

  // Get all teams
  getAllTeams() : Observable<Team[]>{
    return this.http.get<Team[]>(this.baseUrl);
  }
}
