import { IPagePart } from "./IPartPage";

export class Header implements IPagePart {
    x: number = 0;
    y: number = 0;
    width: number = 100;
    heigh: number = 20;
    content: string = "This is a HEADER"

    public render(): void {
        console.log(`${this.content} ${this.width}x${this.heigh} pixels`);
    }
}