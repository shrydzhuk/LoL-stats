import { IItem } from "./item";
import { ISpell } from "./spell";

export interface ISummonerChampion {
    name: string;
    level: number;
    image: string;

    spells: ISpell[];
    items: IItem[];
}
