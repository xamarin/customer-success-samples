//
//  StringWorker.h
//  C++Project
//
//  Created by Jon Davis on 7/23/15.
//  Copyright (c) 2015 Xamarin Inc. All rights reserved.
//

#ifndef __C__Project__StringWorker__
#define __C__Project__StringWorker__

#include <cstring>
#include <stdlib.h>
#include <stdio.h>

class StringWorker
{
private:
    char* m_String;

public:
    StringWorker(const char* string = NULL)
    {
        m_String = NULL;
        SetString(string);
    }
    
    ~StringWorker()
    {
        delete m_String;
    }
    
    void SetString(const char* string)
    {
      if (m_String != NULL) free (m_String);
        
        if (string != NULL)
        {
            m_String = (char *)strdup(string);
        }
        else
        {
            m_String = NULL;
        }
    }
    
    const char* String() const
    {
        return m_String;
    }
};

#endif /* defined(__C__Project__StringWorker__) */
