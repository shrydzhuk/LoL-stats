import { Component, Input, OnInit } from '@angular/core';
import { ISummonerMatch } from 'src/app/models/matches/summonerMatch';

@Component({
  selector: 'app-matches-list',
  templateUrl: './matches-list.component.html',
  styleUrls: ['./matches-list.component.scss']
})
export class MatchesListComponent implements OnInit {
  @Input() matches: ISummonerMatch[];
  
  constructor() { }

  ngOnInit() {
  }

}
