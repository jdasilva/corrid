﻿#region Apache License Notice

// Copyright © 2019, Silverlake Software LLC
// 
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
// 
//     http://www.apache.org/licenses/LICENSE-2.0
// 
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// See the License for the specific language governing permissions and
// limitations under the License.

#endregion

// Created by Jamie da Silva on 6/12/2019 9:53 PM

namespace Corrid.Internal
{
    public abstract class CorridContextBase : ICorridContext, ICorridContextUpdater
    {
        public abstract string Id { get; }

        public abstract void BeginExecutionScope();

        public abstract void BeginExecutionScope(string incomingId);

        public abstract void EndExecutionScope();
    }
}