import { Component, OnDestroy, OnInit } from '@angular/core';
import { NbToastrService } from '@nebular/theme';
import { Subscription } from 'rxjs';
import { ISummoner } from 'src/app/models/summoners/summoner';
import { ApiService } from 'src/app/services/api.service';
import { Endpoints } from 'src/app/utils/endpoints';

@Component({
  selector: 'app-summoners-matches',
  templateUrl: './summoners-matches.component.html',
  styleUrls: ['./summoners-matches.component.scss']
})
export class SummonersMatchesComponent implements OnInit, OnDestroy {
  public name: string = '';
  public matchesCount: number = 5;

  private summonerSubscription: Subscription;

  constructor(
    private apiService: ApiService,
    private toastrService: NbToastrService) { }

  ngOnInit(): void {
  }

  ngOnDestroy(): void {
    if (this.summonerSubscription) {
      this.summonerSubscription.unsubscribe();
    }
  }

  getMatches(name: string): void {
    this.summonerSubscription = this.apiService.get<ISummoner>(`${Endpoints.Summoners}/${name}`).subscribe((summoner) => {
      if (!summoner) {
        this.showSummonerNotFound();
        return;
      }

      console.log(summoner);

      // TODO: Get Matches by Summoner's PUUID
    }, (error) => {
      this.showSummonerNotFound();
    });
  }

  private showSummonerNotFound(): void {
    this.toastrService.danger('', 'Summoner not found.');
  }

}
