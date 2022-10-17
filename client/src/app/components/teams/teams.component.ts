import { Component, Input, OnInit } from '@angular/core';
import { ITeam } from 'src/app/models/matches/team';

@Component({
  selector: 'app-teams',
  templateUrl: './teams.component.html',
  styleUrls: ['./teams.component.scss']
})
export class TeamsComponent implements OnInit {
  @Input() teams: ITeam[];
  constructor() { }

  ngOnInit() {
  }

}
