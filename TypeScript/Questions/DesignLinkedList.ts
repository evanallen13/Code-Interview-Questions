export class MyLinkedList {
    public head: Node;
    constructor() {
      this.head = null;
    }
  
    get(index: number): number {
      let res = -1;
      let dummy = this.head;
      let i = 0;
      while (dummy) {
          if(i === index)
              return dummy.val;
          dummy = dummy.next;
          i++;
      }
      return res;
    }
  
    addAtHead(val: number): void {
      let newHead = new Node(val);
      newHead.next = this.head;
      this.head = newHead;
    }
  
    addAtTail(val: number): void {
      if (this.head === null) {
        this.head = new Node(val);
      } else {
        let dummy = this.head;
        while (dummy) {
          if (dummy.next === null) {
            dummy.next = new Node(val);
            break;
          }
          dummy = dummy.next;
        }
      }
    }
  
    addAtIndex(index: number, val: number): void {}
  
    deleteAtIndex(index: number): void {}
  }
  
  class Node {
    public val: number;
    public next: Node;
    constructor(val: number) {
      this.val = val;
      this.next = null;
    }
  }