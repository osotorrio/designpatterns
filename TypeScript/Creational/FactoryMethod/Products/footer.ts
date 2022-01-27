import { IPagePart } from "./IPartPage";

export class Footer implements IPagePart {
    width: number = 100;
    heigh: number = 10;
    content: string = "This is a FOOTER"

    public render(): void {
        console.log(`${this.content} ${this.width}x${this.heigh} pixels`);
    }
}