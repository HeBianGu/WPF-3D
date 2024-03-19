using System;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Text;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkOverrideInformation
	/// </summary>
	/// <remarks>
	///    Factory object override information
	///
	/// vtkOverrideInformation is used to represent the information about
	/// a class which is overridden in a vtkObjectFactory.
	///
	/// </remarks>
	// Token: 0x02000B77 RID: 2935
	public class vtkOverrideInformation : vtkObject
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x0601EA0B RID: 125451 RVA: 0x002B6F1B File Offset: 0x002B511B
		static vtkOverrideInformation()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkOverrideInformation.MRClassNameKey, Type.GetType("Kitware.VTK.vtkOverrideInformation"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x0601EA0C RID: 125452 RVA: 0x002B6F43 File Offset: 0x002B5143
		public vtkOverrideInformation(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x0601EA0D RID: 125453
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkOverrideInformation_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601EA0E RID: 125454 RVA: 0x002B6F54 File Offset: 0x002B5154
		public new static vtkOverrideInformation New()
		{
			vtkOverrideInformation result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkOverrideInformation.vtkOverrideInformation_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkOverrideInformation)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601EA0F RID: 125455 RVA: 0x002B6FA8 File Offset: 0x002B51A8
		public vtkOverrideInformation() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkOverrideInformation.vtkOverrideInformation_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x0601EA10 RID: 125456 RVA: 0x002B6FEC File Offset: 0x002B51EC
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x0601EA11 RID: 125457
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkOverrideInformation_GetClassOverrideName_01(HandleRef pThis);

		/// <summary>
		/// Returns the name of the class being overridden.  For example,
		/// if you had a factory that provided an override for
		/// vtkVertex, then this function would return "vtkVertex"
		/// </summary>
		// Token: 0x0601EA12 RID: 125458 RVA: 0x002B6FF8 File Offset: 0x002B51F8
		public string GetClassOverrideName()
		{
			string s = Marshal.PtrToStringAnsi(vtkOverrideInformation.vtkOverrideInformation_GetClassOverrideName_01(base.GetCppThis()));
			return Encoding.UTF8.GetString(Encoding.Default.GetBytes(s));
		}

		// Token: 0x0601EA13 RID: 125459
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkOverrideInformation_GetClassOverrideWithName_02(HandleRef pThis);

		/// <summary>
		/// Returns the name of the class that will override the class.
		/// For example, if you had a factory that provided an override for
		/// vtkVertex called vtkMyVertex, then this would return "vtkMyVertex"
		/// </summary>
		// Token: 0x0601EA14 RID: 125460 RVA: 0x002B7034 File Offset: 0x002B5234
		public string GetClassOverrideWithName()
		{
			string s = Marshal.PtrToStringAnsi(vtkOverrideInformation.vtkOverrideInformation_GetClassOverrideWithName_02(base.GetCppThis()));
			return Encoding.UTF8.GetString(Encoding.Default.GetBytes(s));
		}

		// Token: 0x0601EA15 RID: 125461
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkOverrideInformation_GetDescription_03(HandleRef pThis);

		/// <summary>
		/// Return a human readable or GUI displayable description of this
		/// override.
		/// </summary>
		// Token: 0x0601EA16 RID: 125462 RVA: 0x002B7070 File Offset: 0x002B5270
		public string GetDescription()
		{
			string s = Marshal.PtrToStringAnsi(vtkOverrideInformation.vtkOverrideInformation_GetDescription_03(base.GetCppThis()));
			return Encoding.UTF8.GetString(Encoding.Default.GetBytes(s));
		}

		// Token: 0x0601EA17 RID: 125463
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkOverrideInformation_GetNumberOfGenerationsFromBase_04(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601EA18 RID: 125464 RVA: 0x002B70AC File Offset: 0x002B52AC
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkOverrideInformation.vtkOverrideInformation_GetNumberOfGenerationsFromBase_04(base.GetCppThis(), type);
		}

		// Token: 0x0601EA19 RID: 125465
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkOverrideInformation_GetNumberOfGenerationsFromBaseType_05([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601EA1A RID: 125466 RVA: 0x002B70CC File Offset: 0x002B52CC
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkOverrideInformation.vtkOverrideInformation_GetNumberOfGenerationsFromBaseType_05(type);
		}

		// Token: 0x0601EA1B RID: 125467
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkOverrideInformation_GetObjectFactory_06(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Return the specific object factory that this override occurs in.
		/// </summary>
		// Token: 0x0601EA1C RID: 125468 RVA: 0x002B70E8 File Offset: 0x002B52E8
		public vtkObjectFactory GetObjectFactory()
		{
			vtkObjectFactory vtkObjectFactory = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkOverrideInformation.vtkOverrideInformation_GetObjectFactory_06(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
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

		// Token: 0x0601EA1D RID: 125469
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkOverrideInformation_IsA_07(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601EA1E RID: 125470 RVA: 0x002B7158 File Offset: 0x002B5358
		public override int IsA(string type)
		{
			return vtkOverrideInformation.vtkOverrideInformation_IsA_07(base.GetCppThis(), type);
		}

		// Token: 0x0601EA1F RID: 125471
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkOverrideInformation_IsTypeOf_08([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601EA20 RID: 125472 RVA: 0x002B7178 File Offset: 0x002B5378
		public new static int IsTypeOf(string type)
		{
			return vtkOverrideInformation.vtkOverrideInformation_IsTypeOf_08(type);
		}

		// Token: 0x0601EA21 RID: 125473
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkOverrideInformation_NewInstance_10(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601EA22 RID: 125474 RVA: 0x002B7194 File Offset: 0x002B5394
		public new vtkOverrideInformation NewInstance()
		{
			vtkOverrideInformation result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkOverrideInformation.vtkOverrideInformation_NewInstance_10(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkOverrideInformation)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x0601EA23 RID: 125475
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkOverrideInformation_SafeDownCast_11(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601EA24 RID: 125476 RVA: 0x002B71F0 File Offset: 0x002B53F0
		public new static vtkOverrideInformation SafeDownCast(vtkObjectBase o)
		{
			vtkOverrideInformation vtkOverrideInformation = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkOverrideInformation.vtkOverrideInformation_SafeDownCast_11((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkOverrideInformation = (vtkOverrideInformation)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkOverrideInformation.Register(null);
				}
			}
			return vtkOverrideInformation;
		}

		// Token: 0x0601EA25 RID: 125477
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkOverrideInformation_SetClassOverrideName_12(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string _arg);

		/// <summary>
		/// Set the class override name
		/// </summary>
		// Token: 0x0601EA26 RID: 125478 RVA: 0x002B726F File Offset: 0x002B546F
		public virtual void SetClassOverrideName(string _arg)
		{
			vtkOverrideInformation.vtkOverrideInformation_SetClassOverrideName_12(base.GetCppThis(), _arg);
		}

		// Token: 0x0601EA27 RID: 125479
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkOverrideInformation_SetClassOverrideWithName_13(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string _arg);

		/// <summary>
		/// Set the class override with name
		/// </summary>
		// Token: 0x0601EA28 RID: 125480 RVA: 0x002B727F File Offset: 0x002B547F
		public virtual void SetClassOverrideWithName(string _arg)
		{
			vtkOverrideInformation.vtkOverrideInformation_SetClassOverrideWithName_13(base.GetCppThis(), _arg);
		}

		// Token: 0x0601EA29 RID: 125481
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkOverrideInformation_SetDescription_14(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string _arg);

		/// <summary>
		/// Set the description
		/// </summary>
		// Token: 0x0601EA2A RID: 125482 RVA: 0x002B728F File Offset: 0x002B548F
		public virtual void SetDescription(string _arg)
		{
			vtkOverrideInformation.vtkOverrideInformation_SetDescription_14(base.GetCppThis(), _arg);
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x040020D2 RID: 8402
		public new const string MRFullTypeName = "Kitware.VTK.vtkOverrideInformation";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x040020D3 RID: 8403
		public new static readonly string MRClassNameKey = "class vtkOverrideInformation";
	}
}
