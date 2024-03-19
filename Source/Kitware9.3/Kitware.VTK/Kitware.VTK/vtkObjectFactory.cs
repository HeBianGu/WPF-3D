using System;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Text;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkObjectFactory
	/// </summary>
	/// <remarks>
	///    abstract base class for vtkObjectFactories
	///
	/// vtkObjectFactory is used to create vtk objects.   The base class
	/// vtkObjectFactory contains a static method CreateInstance which is used
	/// to create vtk objects from the list of registered vtkObjectFactory
	/// sub-classes.   The first time CreateInstance is called, all dll's or shared
	/// libraries in the environment variable VTK_AUTOLOAD_PATH are loaded into
	/// the current process.   The C functions vtkLoad, and vtkGetFactoryVersion are
	/// called on each dll.  To implement these functions in a shared library or
	/// dll, use the macro:
	/// VTK_FACTORY_INTERFACE_IMPLEMENT.
	/// VTK_AUTOLOAD_PATH is an environment variable
	/// containing a colon separated (semi-colon on win32) list of paths.
	///
	/// The vtkObjectFactory can be use to override the creation of any object
	/// in VTK with a sub-class of that object.  The factories can be registered
	/// either at run time with the VTK_AUTOLOAD_PATH, or at compile time
	/// with the vtkObjectFactory::RegisterFactory method.
	///
	/// </remarks>
	// Token: 0x02000059 RID: 89
	public abstract class vtkObjectFactory : vtkObject
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x06001009 RID: 4105 RVA: 0x0001D20B File Offset: 0x0001B40B
		static vtkObjectFactory()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkObjectFactory.MRClassNameKey, Type.GetType("Kitware.VTK.vtkObjectFactory"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x0600100A RID: 4106 RVA: 0x0001D233 File Offset: 0x0001B433
		public vtkObjectFactory(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x0600100B RID: 4107 RVA: 0x0001D241 File Offset: 0x0001B441
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x0600100C RID: 4108
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkObjectFactory_CreateAllInstance_01([MarshalAs(UnmanagedType.LPUTF8Str)] string vtkclassname, HandleRef retList);

		/// <summary>
		/// Create all possible instances of the named vtk object.
		/// Each registered vtkObjectFactory will be asked, and the
		/// result will be stored in the user allocated vtkCollection
		/// passed in to the function.
		/// </summary>
		// Token: 0x0600100D RID: 4109 RVA: 0x0001D24C File Offset: 0x0001B44C
		public static void CreateAllInstance(string vtkclassname, vtkCollection retList)
		{
			vtkObjectFactory.vtkObjectFactory_CreateAllInstance_01(vtkclassname, (retList == null) ? default(HandleRef) : retList.GetCppThis());
		}

		// Token: 0x0600100E RID: 4110
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkObjectFactory_CreateInstance_02([MarshalAs(UnmanagedType.LPUTF8Str)] string vtkclassname, byte isAbstract, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Create and return an instance of the named vtk object.
		/// Each loaded vtkObjectFactory will be asked in the order
		/// the factory was in the VTK_AUTOLOAD_PATH.  After the
		/// first factory returns the object no other factories are asked.
		/// isAbstract is no longer used. This method calls
		/// vtkObjectBase::InitializeObjectBase() on the instance when the
		/// return value is non-nullptr.
		/// </summary>
		// Token: 0x0600100F RID: 4111 RVA: 0x0001D278 File Offset: 0x0001B478
		public static vtkObject CreateInstance(string vtkclassname, bool isAbstract)
		{
			vtkObject result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkObjectFactory.vtkObjectFactory_CreateInstance_02(vtkclassname, isAbstract ? (byte)1 : (byte)0, ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkObject)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x06001010 RID: 4112
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkObjectFactory_Disable_03(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string className);

		/// <summary>
		/// Set all enable flags for the given class to 0.  This will
		/// mean that the factory will stop producing class with the given
		/// name.
		/// </summary>
		// Token: 0x06001011 RID: 4113 RVA: 0x0001D2D6 File Offset: 0x0001B4D6
		public virtual void Disable(string className)
		{
			vtkObjectFactory.vtkObjectFactory_Disable_03(base.GetCppThis(), className);
		}

		// Token: 0x06001012 RID: 4114
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkObjectFactory_GetClassOverrideName_04(HandleRef pThis, int index);

		/// <summary>
		/// Return the name of a class override at the given index.
		/// </summary>
		// Token: 0x06001013 RID: 4115 RVA: 0x0001D2E8 File Offset: 0x0001B4E8
		public virtual string GetClassOverrideName(int index)
		{
			string s = Marshal.PtrToStringAnsi(vtkObjectFactory.vtkObjectFactory_GetClassOverrideName_04(base.GetCppThis(), index));
			return Encoding.UTF8.GetString(Encoding.Default.GetBytes(s));
		}

		// Token: 0x06001014 RID: 4116
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkObjectFactory_GetClassOverrideWithName_05(HandleRef pThis, int index);

		/// <summary>
		/// Return the name of the class that will override the class
		/// at the given index
		/// </summary>
		// Token: 0x06001015 RID: 4117 RVA: 0x0001D324 File Offset: 0x0001B524
		public virtual string GetClassOverrideWithName(int index)
		{
			string s = Marshal.PtrToStringAnsi(vtkObjectFactory.vtkObjectFactory_GetClassOverrideWithName_05(base.GetCppThis(), index));
			return Encoding.UTF8.GetString(Encoding.Default.GetBytes(s));
		}

		// Token: 0x06001016 RID: 4118
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkObjectFactory_GetDescription_06(HandleRef pThis);

		/// <summary>
		/// Return a descriptive string describing the factory.
		/// </summary>
		// Token: 0x06001017 RID: 4119 RVA: 0x0001D360 File Offset: 0x0001B560
		public virtual string GetDescription()
		{
			string s = Marshal.PtrToStringAnsi(vtkObjectFactory.vtkObjectFactory_GetDescription_06(base.GetCppThis()));
			return Encoding.UTF8.GetString(Encoding.Default.GetBytes(s));
		}

		// Token: 0x06001018 RID: 4120
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkObjectFactory_GetEnableFlag_07(HandleRef pThis, int index);

		/// <summary>
		/// Return the enable flag for the class at the given index.
		/// </summary>
		// Token: 0x06001019 RID: 4121 RVA: 0x0001D39C File Offset: 0x0001B59C
		public virtual int GetEnableFlag(int index)
		{
			return vtkObjectFactory.vtkObjectFactory_GetEnableFlag_07(base.GetCppThis(), index);
		}

		// Token: 0x0600101A RID: 4122
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkObjectFactory_GetEnableFlag_08(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string className, [MarshalAs(UnmanagedType.LPUTF8Str)] string subclassName);

		/// <summary>
		/// Set and Get the Enable flag for the specific override of className.
		/// if subclassName is null, then it is ignored.
		/// </summary>
		// Token: 0x0600101B RID: 4123 RVA: 0x0001D3BC File Offset: 0x0001B5BC
		public virtual int GetEnableFlag(string className, string subclassName)
		{
			return vtkObjectFactory.vtkObjectFactory_GetEnableFlag_08(base.GetCppThis(), className, subclassName);
		}

		// Token: 0x0600101C RID: 4124
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkObjectFactory_GetLibraryPath_09(HandleRef pThis);

		/// <summary>
		/// This returns the path to a dynamically loaded factory.
		/// </summary>
		// Token: 0x0600101D RID: 4125 RVA: 0x0001D3E0 File Offset: 0x0001B5E0
		public virtual string GetLibraryPath()
		{
			string s = Marshal.PtrToStringAnsi(vtkObjectFactory.vtkObjectFactory_GetLibraryPath_09(base.GetCppThis()));
			return Encoding.UTF8.GetString(Encoding.Default.GetBytes(s));
		}

		// Token: 0x0600101E RID: 4126
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkObjectFactory_GetNumberOfGenerationsFromBase_10(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		/// Set the enable flag for a given named class subclass pair
		/// for all registered factories.
		/// </summary>
		// Token: 0x0600101F RID: 4127 RVA: 0x0001D41C File Offset: 0x0001B61C
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkObjectFactory.vtkObjectFactory_GetNumberOfGenerationsFromBase_10(base.GetCppThis(), type);
		}

		// Token: 0x06001020 RID: 4128
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkObjectFactory_GetNumberOfGenerationsFromBaseType_11([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		/// Set the enable flag for a given named class subclass pair
		/// for all registered factories.
		/// </summary>
		// Token: 0x06001021 RID: 4129 RVA: 0x0001D43C File Offset: 0x0001B63C
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkObjectFactory.vtkObjectFactory_GetNumberOfGenerationsFromBaseType_11(type);
		}

		// Token: 0x06001022 RID: 4130
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkObjectFactory_GetNumberOfOverrides_12(HandleRef pThis);

		/// <summary>
		/// Return number of overrides this factory can create.
		/// </summary>
		// Token: 0x06001023 RID: 4131 RVA: 0x0001D458 File Offset: 0x0001B658
		public virtual int GetNumberOfOverrides()
		{
			return vtkObjectFactory.vtkObjectFactory_GetNumberOfOverrides_12(base.GetCppThis());
		}

		// Token: 0x06001024 RID: 4132
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkObjectFactory_GetOverrideDescription_13(HandleRef pThis, int index);

		/// <summary>
		/// Return the description for a the class override at the given
		/// index.
		/// </summary>
		// Token: 0x06001025 RID: 4133 RVA: 0x0001D478 File Offset: 0x0001B678
		public virtual string GetOverrideDescription(int index)
		{
			string s = Marshal.PtrToStringAnsi(vtkObjectFactory.vtkObjectFactory_GetOverrideDescription_13(base.GetCppThis(), index));
			return Encoding.UTF8.GetString(Encoding.Default.GetBytes(s));
		}

		// Token: 0x06001026 RID: 4134
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkObjectFactory_GetOverrideInformation_14([MarshalAs(UnmanagedType.LPUTF8Str)] string name, HandleRef arg1);

		/// <summary>
		/// Fill the given collection with all the overrides for
		/// the class with the given name.
		/// </summary>
		// Token: 0x06001027 RID: 4135 RVA: 0x0001D4B4 File Offset: 0x0001B6B4
		public static void GetOverrideInformation(string name, vtkOverrideInformationCollection arg1)
		{
			vtkObjectFactory.vtkObjectFactory_GetOverrideInformation_14(name, (arg1 == null) ? default(HandleRef) : arg1.GetCppThis());
		}

		// Token: 0x06001028 RID: 4136
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkObjectFactory_GetRegisteredFactories_15(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Return the list of all registered factories.  This is NOT a copy,
		/// do not remove items from this list!
		/// </summary>
		// Token: 0x06001029 RID: 4137 RVA: 0x0001D4E0 File Offset: 0x0001B6E0
		public static vtkObjectFactoryCollection GetRegisteredFactories()
		{
			vtkObjectFactoryCollection vtkObjectFactoryCollection = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkObjectFactory.vtkObjectFactory_GetRegisteredFactories_15(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkObjectFactoryCollection = (vtkObjectFactoryCollection)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkObjectFactoryCollection.Register(null);
				}
			}
			return vtkObjectFactoryCollection;
		}

		// Token: 0x0600102A RID: 4138
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkObjectFactory_GetVTKSourceVersion_16(HandleRef pThis);

		/// <summary>
		/// All sub-classes of vtkObjectFactory should must return the version of
		/// VTK they were built with.  This should be implemented with the macro
		/// VTK_SOURCE_VERSION and NOT a call to vtkVersion::GetVTKSourceVersion.
		/// As the version needs to be compiled into the file as a string constant.
		/// This is critical to determine possible incompatible dynamic factory loads.
		/// </summary>
		// Token: 0x0600102B RID: 4139 RVA: 0x0001D54C File Offset: 0x0001B74C
		public virtual string GetVTKSourceVersion()
		{
			string s = Marshal.PtrToStringAnsi(vtkObjectFactory.vtkObjectFactory_GetVTKSourceVersion_16(base.GetCppThis()));
			return Encoding.UTF8.GetString(Encoding.Default.GetBytes(s));
		}

		// Token: 0x0600102C RID: 4140
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkObjectFactory_HasOverride_17(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string className);

		/// <summary>
		/// Return 1 if this factory overrides the given class name, 0 otherwise.
		/// </summary>
		// Token: 0x0600102D RID: 4141 RVA: 0x0001D588 File Offset: 0x0001B788
		public virtual int HasOverride(string className)
		{
			return vtkObjectFactory.vtkObjectFactory_HasOverride_17(base.GetCppThis(), className);
		}

		// Token: 0x0600102E RID: 4142
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkObjectFactory_HasOverride_18(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string className, [MarshalAs(UnmanagedType.LPUTF8Str)] string subclassName);

		/// <summary>
		/// Return 1 if this factory overrides the given class name, 0 otherwise.
		/// </summary>
		// Token: 0x0600102F RID: 4143 RVA: 0x0001D5A8 File Offset: 0x0001B7A8
		public virtual int HasOverride(string className, string subclassName)
		{
			return vtkObjectFactory.vtkObjectFactory_HasOverride_18(base.GetCppThis(), className, subclassName);
		}

		// Token: 0x06001030 RID: 4144
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkObjectFactory_HasOverrideAny_19([MarshalAs(UnmanagedType.LPUTF8Str)] string className);

		/// <summary>
		/// return 1 if one of the registered factories
		/// overrides the given class name
		/// </summary>
		// Token: 0x06001031 RID: 4145 RVA: 0x0001D5CC File Offset: 0x0001B7CC
		public static int HasOverrideAny(string className)
		{
			return vtkObjectFactory.vtkObjectFactory_HasOverrideAny_19(className);
		}

		// Token: 0x06001032 RID: 4146
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkObjectFactory_IsA_20(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		/// Set the enable flag for a given named class subclass pair
		/// for all registered factories.
		/// </summary>
		// Token: 0x06001033 RID: 4147 RVA: 0x0001D5E8 File Offset: 0x0001B7E8
		public override int IsA(string type)
		{
			return vtkObjectFactory.vtkObjectFactory_IsA_20(base.GetCppThis(), type);
		}

		// Token: 0x06001034 RID: 4148
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkObjectFactory_IsTypeOf_21([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		/// Set the enable flag for a given named class subclass pair
		/// for all registered factories.
		/// </summary>
		// Token: 0x06001035 RID: 4149 RVA: 0x0001D608 File Offset: 0x0001B808
		public new static int IsTypeOf(string type)
		{
			return vtkObjectFactory.vtkObjectFactory_IsTypeOf_21(type);
		}

		// Token: 0x06001036 RID: 4150
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkObjectFactory_NewInstance_22(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Set the enable flag for a given named class subclass pair
		/// for all registered factories.
		/// </summary>
		// Token: 0x06001037 RID: 4151 RVA: 0x0001D624 File Offset: 0x0001B824
		public new vtkObjectFactory NewInstance()
		{
			vtkObjectFactory result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkObjectFactory.vtkObjectFactory_NewInstance_22(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkObjectFactory)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x06001038 RID: 4152
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkObjectFactory_ReHash_23();

		/// <summary>
		/// Re-check the VTK_AUTOLOAD_PATH for new factory libraries.
		/// This calls UnRegisterAll before re-loading
		/// </summary>
		// Token: 0x06001039 RID: 4153 RVA: 0x0001D67E File Offset: 0x0001B87E
		public static void ReHash()
		{
			vtkObjectFactory.vtkObjectFactory_ReHash_23();
		}

		// Token: 0x0600103A RID: 4154
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkObjectFactory_RegisterFactory_24(HandleRef arg0);

		/// <summary>
		/// Register a factory so it can be used to create vtk objects
		/// </summary>
		// Token: 0x0600103B RID: 4155 RVA: 0x0001D688 File Offset: 0x0001B888
		public static void RegisterFactory(vtkObjectFactory arg0)
		{
			vtkObjectFactory.vtkObjectFactory_RegisterFactory_24((arg0 == null) ? default(HandleRef) : arg0.GetCppThis());
		}

		// Token: 0x0600103C RID: 4156
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkObjectFactory_SafeDownCast_25(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Set the enable flag for a given named class subclass pair
		/// for all registered factories.
		/// </summary>
		// Token: 0x0600103D RID: 4157 RVA: 0x0001D6B4 File Offset: 0x0001B8B4
		public new static vtkObjectFactory SafeDownCast(vtkObjectBase o)
		{
			vtkObjectFactory vtkObjectFactory = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkObjectFactory.vtkObjectFactory_SafeDownCast_25((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkObjectFactory = (vtkObjectFactory)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkObjectFactory.Register(null);
				}
			}
			return vtkObjectFactory;
		}

		// Token: 0x0600103E RID: 4158
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkObjectFactory_SetAllEnableFlags_26(int flag, [MarshalAs(UnmanagedType.LPUTF8Str)] string className);

		/// <summary>
		/// Set the enable flag for a given named class for all registered
		/// factories.
		/// </summary>
		// Token: 0x0600103F RID: 4159 RVA: 0x0001D733 File Offset: 0x0001B933
		public static void SetAllEnableFlags(int flag, string className)
		{
			vtkObjectFactory.vtkObjectFactory_SetAllEnableFlags_26(flag, className);
		}

		// Token: 0x06001040 RID: 4160
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkObjectFactory_SetAllEnableFlags_27(int flag, [MarshalAs(UnmanagedType.LPUTF8Str)] string className, [MarshalAs(UnmanagedType.LPUTF8Str)] string subclassName);

		/// <summary>
		/// Set the enable flag for a given named class subclass pair
		/// for all registered factories.
		/// </summary>
		// Token: 0x06001041 RID: 4161 RVA: 0x0001D73E File Offset: 0x0001B93E
		public static void SetAllEnableFlags(int flag, string className, string subclassName)
		{
			vtkObjectFactory.vtkObjectFactory_SetAllEnableFlags_27(flag, className, subclassName);
		}

		// Token: 0x06001042 RID: 4162
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkObjectFactory_SetEnableFlag_28(HandleRef pThis, int flag, [MarshalAs(UnmanagedType.LPUTF8Str)] string className, [MarshalAs(UnmanagedType.LPUTF8Str)] string subclassName);

		/// <summary>
		/// Set and Get the Enable flag for the specific override of className.
		/// if subclassName is null, then it is ignored.
		/// </summary>
		// Token: 0x06001043 RID: 4163 RVA: 0x0001D74A File Offset: 0x0001B94A
		public virtual void SetEnableFlag(int flag, string className, string subclassName)
		{
			vtkObjectFactory.vtkObjectFactory_SetEnableFlag_28(base.GetCppThis(), flag, className, subclassName);
		}

		// Token: 0x06001044 RID: 4164
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkObjectFactory_UnRegisterAllFactories_29();

		/// <summary>
		/// Unregister all factories
		/// </summary>
		// Token: 0x06001045 RID: 4165 RVA: 0x0001D75C File Offset: 0x0001B95C
		public static void UnRegisterAllFactories()
		{
			vtkObjectFactory.vtkObjectFactory_UnRegisterAllFactories_29();
		}

		// Token: 0x06001046 RID: 4166
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkObjectFactory_UnRegisterFactory_30(HandleRef arg0);

		/// <summary>
		/// Remove a factory from the list of registered factories
		/// </summary>
		// Token: 0x06001047 RID: 4167 RVA: 0x0001D768 File Offset: 0x0001B968
		public static void UnRegisterFactory(vtkObjectFactory arg0)
		{
			vtkObjectFactory.vtkObjectFactory_UnRegisterFactory_30((arg0 == null) ? default(HandleRef) : arg0.GetCppThis());
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04000434 RID: 1076
		public new const string MRFullTypeName = "Kitware.VTK.vtkObjectFactory";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04000435 RID: 1077
		public new static readonly string MRClassNameKey = "class vtkObjectFactory";

		/// <summary>
		/// This returns the path to a dynamically loaded factory.
		/// </summary>
		// Token: 0x0200005A RID: 90
		// (Invoke) Token: 0x06001049 RID: 4169
		public delegate IntPtr CreateFunction();
	}
}
