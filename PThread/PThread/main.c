//
//  main.cpp
//  PThread
//
//  Created by Abdul Rahim on 2/13/16.
//  Copyright (c) 2016 Abdul Rahim. All rights reserved.
//

#include <pthread.h>
#include <unistd.h>
#include <stdio.h>

static void *child(void *ignored)
{
    while(1)
    {
        sleep(5);
    printf("\nChild is done sleeping 5 seconds\n");
    
    }
    return NULL;
    
}

static void *thread1(void *ignored)
{
    pthread_t child_thread;
    int code;
    code = pthread_create(&child_thread, NULL, child, NULL);

    char s;
    
    printf("This is the main thread. Enter any key to kill the second thread: ");
    scanf("%c",&s);
    
    if(s!='\0')
    {
        pthread_cancel(child_thread);
        printf("\nChild thread has been canceled.....");
    }
    return NULL;
}



int main(int argc, const char * argv[])
{
    
    pthread_t thread_1;
    pthread_create(&thread_1, NULL, thread1,NULL);
    pthread_join(thread_1, NULL);


    return 0;
}

