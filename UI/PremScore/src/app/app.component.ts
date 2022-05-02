import {Component, OnInit} from '@angular/core';
import {TeamsService} from "./service/teams.service";
import {Team} from "../models/team.model";

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.css']
})
export class AppComponent implements OnInit{
  title = 'PremScore';
  teams: Team[] = [];

  constructor(private teamService: TeamsService) {

  }

  ngOnInit(): void {
    this.getAllTeams();
  }

  getAllTeams() {
    this.teamService.getAllTeams()
      .subscribe(
        response => {
          this.teams = response;
        }
      )
  }
}
