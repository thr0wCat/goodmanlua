﻿//this source code was auto-generated by tolua#, do not modify it
using System;
using LuaInterface;

public class Framework_ResourceMgrWrap
{
	public static void Register(LuaState L)
	{
		L.BeginClass(typeof(Framework.ResourceMgr), typeof(Framework.MonoSingleton<Framework.ResourceMgr>));
		L.RegFunction("Init", Init);
		L.RegFunction("Clone", Clone);
		L.RegFunction("Destroy", Destroy);
		L.RegFunction("GameGC", GameGC);
		L.RegFunction("UnloadUnusedAssets", UnloadUnusedAssets);
		L.RegFunction("UnloadObject", UnloadObject);
		L.RegFunction("AddProxy", AddProxy);
		L.RegFunction("CancleAllProxy", CancleAllProxy);
		L.RegFunction("__eq", op_Equality);
		L.RegFunction("__tostring", ToLua.op_ToString);
		L.RegVar("ResourceMgrInitHandler", get_ResourceMgrInitHandler, set_ResourceMgrInitHandler);
		L.EndClass();
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int Init(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 1);
			Framework.ResourceMgr obj = (Framework.ResourceMgr)ToLua.CheckObject<Framework.ResourceMgr>(L, 1);
			obj.Init();
			return 0;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int Clone(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 2);
			Framework.ResourceMgr obj = (Framework.ResourceMgr)ToLua.CheckObject<Framework.ResourceMgr>(L, 1);
			UnityEngine.GameObject arg0 = (UnityEngine.GameObject)ToLua.CheckObject(L, 2, typeof(UnityEngine.GameObject));
			UnityEngine.GameObject o = obj.Clone(arg0);
			ToLua.PushSealed(L, o);
			return 1;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int Destroy(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 2);
			Framework.ResourceMgr obj = (Framework.ResourceMgr)ToLua.CheckObject<Framework.ResourceMgr>(L, 1);
			UnityEngine.GameObject arg0 = (UnityEngine.GameObject)ToLua.CheckObject(L, 2, typeof(UnityEngine.GameObject));
			obj.Destroy(arg0);
			return 0;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int GameGC(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 1);
			Framework.ResourceMgr obj = (Framework.ResourceMgr)ToLua.CheckObject<Framework.ResourceMgr>(L, 1);
			obj.GameGC();
			return 0;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int UnloadUnusedAssets(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 2);
			Framework.ResourceMgr obj = (Framework.ResourceMgr)ToLua.CheckObject<Framework.ResourceMgr>(L, 1);
			System.Action<UnityEngine.AsyncOperation> arg0 = (System.Action<UnityEngine.AsyncOperation>)ToLua.CheckDelegate<System.Action<UnityEngine.AsyncOperation>>(L, 2);
			obj.UnloadUnusedAssets(arg0);
			return 0;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int UnloadObject(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 3);
			Framework.ResourceMgr obj = (Framework.ResourceMgr)ToLua.CheckObject<Framework.ResourceMgr>(L, 1);
			Framework.AssetType arg0 = (Framework.AssetType)ToLua.CheckObject(L, 2, typeof(Framework.AssetType));
			UnityEngine.Object arg1 = (UnityEngine.Object)ToLua.CheckObject<UnityEngine.Object>(L, 3);
			obj.UnloadObject(arg0, arg1);
			return 0;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int AddProxy(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 2);
			Framework.ResourceMgr obj = (Framework.ResourceMgr)ToLua.CheckObject<Framework.ResourceMgr>(L, 1);
			Framework.AsyncProxy arg0 = (Framework.AsyncProxy)ToLua.CheckObject<Framework.AsyncProxy>(L, 2);
			obj.AddProxy(arg0);
			return 0;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int CancleAllProxy(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 1);
			Framework.ResourceMgr obj = (Framework.ResourceMgr)ToLua.CheckObject<Framework.ResourceMgr>(L, 1);
			System.Collections.Generic.IEnumerator<float> o = obj.CancleAllProxy();
			ToLua.PushObject(L, o);
			return 1;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int op_Equality(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 2);
			UnityEngine.Object arg0 = (UnityEngine.Object)ToLua.ToObject(L, 1);
			UnityEngine.Object arg1 = (UnityEngine.Object)ToLua.ToObject(L, 2);
			bool o = arg0 == arg1;
			LuaDLL.lua_pushboolean(L, o);
			return 1;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_ResourceMgrInitHandler(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			Framework.ResourceMgr obj = (Framework.ResourceMgr)o;
			Framework.ManagerInitEventHandler ret = obj.ResourceMgrInitHandler;
			ToLua.Push(L, ret);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o, "attempt to index ResourceMgrInitHandler on a nil value");
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_ResourceMgrInitHandler(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			Framework.ResourceMgr obj = (Framework.ResourceMgr)o;
			Framework.ManagerInitEventHandler arg0 = (Framework.ManagerInitEventHandler)ToLua.CheckDelegate<Framework.ManagerInitEventHandler>(L, 2);
			obj.ResourceMgrInitHandler = arg0;
			return 0;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o, "attempt to index ResourceMgrInitHandler on a nil value");
		}
	}
}

