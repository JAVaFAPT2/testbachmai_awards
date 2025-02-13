import { Injectable } from '@angular/core';

@Injectable({
    providedIn: 'root',
})
export class TabStackService {
    private storageKey = 'tabStack';

    constructor() {}

    add(): void {
        const stacks = this.get();
        stacks.push({ id: Date.now().toString() });
        this.set(stacks);
    }

    remove(): void {
        this.set(this.get().filter(d => d.id !== Date.now().toString()));
    }

    isEmpty(): boolean {
        return this.get().length === 0;
    }

    private get(): { id: string }[] {
        const value: string | null = localStorage.getItem(this.storageKey);
        return value ? JSON.parse(value) : [];
    }

    private set(stacks: { id: string }[]): void {
        localStorage.setItem(this.storageKey, JSON.stringify(stacks));
    }
}
