###
Coffee Script Hanoi.coffee
###

hanoi = (n, from, to, via) ->

    if(n > 1)
        hanoi n - 1, from, via, to

        print from + " -> " + to

        hanoi n - 1, via, to, from
    else 

        print from + " -> " + to

n = readline()

hanoi n, "a", "b", "c"

#JavaScript(spidermonkey)로 실행!!
