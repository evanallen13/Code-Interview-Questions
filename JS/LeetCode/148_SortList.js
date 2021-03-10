
function ListNode(val, next) {
    this.val = (val===undefined ? 0 : val)
    this.next = (next===undefined ? null : next)
 };

var sortList = function(head) {
    if(head === null || head.next === null) return head;

    var curr = head;
    var next = head.next;
    var nextNext = head.next.next;

    console.log(nextNext)

    if(curr.val > next.val){
        head = next;
        head.next = curr;
        head.next.next = nextNext;
    }

    sortList(head.next);

    return head;
};


var head = new ListNode(4);
head.next = new ListNode(2);
head.next.next = new ListNode(1);
head.next.next.next = new ListNode(3);

var dummy = sortList(head);
