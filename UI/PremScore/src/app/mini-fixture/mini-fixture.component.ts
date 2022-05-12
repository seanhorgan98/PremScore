import { Component, OnInit, Input } from '@angular/core';

@Component({
  selector: 'app-mini-fixture',
  templateUrl: './mini-fixture.component.html',
  styleUrls: ['./mini-fixture.component.css']
})
export class MiniFixtureComponent implements OnInit {
  @Input()
  teamOneAbbr: string = "";
  @Input()
  teamTwoAbbr: string = "";
  @Input()
  time: string = "00:00";
  @Input()
  teamNameOne: string = "";
  @Input()
  teamNameTwo: string = "";

  constructor() { }

  ngOnInit(): void {
  }

}
