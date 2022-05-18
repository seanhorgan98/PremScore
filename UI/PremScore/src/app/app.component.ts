import {Component, OnInit} from '@angular/core';
import {TeamsService} from "./service/teams.service";
import {FixtureService} from "./service/fixture.service";
import {Team} from "../models/team.model";
import {Fixture} from "../models/fixture.model";

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.css']
})
export class AppComponent implements OnInit{
  title = 'PremScore';
  teams: Team[] = [];
  upcomingFixtures: Fixture[] = [];

  constructor(private teamService: TeamsService, private fixtureService: FixtureService) {

  }

  ngOnInit(): void {
    this.getAllTeams();
    this.getUpcomingFixtures();
  }

  getAllTeams() {
    this.teamService.getAllTeams()
      .subscribe(
        response => {
          this.teams = response;
        }
      )
  }

  getUpcomingFixtures() {
    this.fixtureService.getUpcomingFixtures()
      .subscribe(
        response => {
          this.upcomingFixtures = response;
        }
      )
  }
}
