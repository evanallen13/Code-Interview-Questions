"use strict";
exports.__esModule = true;
exports.MyLinkedList = void 0;
var MyLinkedList = /** @class */ (function () {
    function MyLinkedList() {
        this.head = null;
    }
    MyLinkedList.prototype.get = function (index) {
        var res = -1;
        var dummy = this.head;
        var i = 0;
        while (dummy) {
            if (i === index)
                return dummy.val;
            dummy = dummy.next;
            i++;
        }
        return res;
    };
    MyLinkedList.prototype.addAtHead = function (val) {
        var newHead = new Node(val);
        newHead.next = this.head;
        this.head = newHead;
    };
    MyLinkedList.prototype.addAtTail = function (val) {
        if (this.head === null) {
            this.head = new Node(val);
        }
        else {
            var dummy = this.head;
            while (dummy) {
                if (dummy.next === null) {
                    dummy.next = new Node(val);
                    break;
                }
                dummy = dummy.next;
            }
        }
    };
    MyLinkedList.prototype.addAtIndex = function (index, val) { };
    MyLinkedList.prototype.deleteAtIndex = function (index) { };
    return MyLinkedList;
}());
exports.MyLinkedList = MyLinkedList;
var Node = /** @class */ (function () {
    function Node(val) {
        this.val = val;
        this.next = null;
    }
    return Node;
}());
