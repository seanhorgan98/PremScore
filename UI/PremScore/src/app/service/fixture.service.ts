import { Injectable } from '@angular/core';
import {HttpClient} from "@angular/common/http";
import {Observable} from "rxjs";
import {Fixture} from "../../models/fixture.model";

@Injectable({
  providedIn: 'root'
})
export class FixtureService {

  baseUrl = "https://localhost:7020/api/Fixtures/upcoming";

  constructor(private http: HttpClient) { }

  getUpcomingFixtures() : Observable<Fixture[]>{
    return this.http.get<Fixture[]>(this.baseUrl)
  }
}
