using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkInformationExecutivePortKey
	/// </summary>
	/// <remarks>
	///    Key for vtkExecutive/Port value pairs.
	///
	/// vtkInformationExecutivePortKey is used to represent keys in
	/// vtkInformation for values that are vtkExecutive instances paired
	/// with port numbers.
	/// </remarks>
	// Token: 0x020009DA RID: 2522
	public class vtkInformationExecutivePortKey : vtkInformationKey
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x0601A43A RID: 107578 RVA: 0x00246FE3 File Offset: 0x002451E3
		static vtkInformationExecutivePortKey()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkInformationExecutivePortKey.MRClassNameKey, Type.GetType("Kitware.VTK.vtkInformationExecutivePortKey"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x0601A43B RID: 107579 RVA: 0x0024700B File Offset: 0x0024520B
		public vtkInformationExecutivePortKey(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x0601A43C RID: 107580 RVA: 0x00247019 File Offset: 0x00245219
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x0601A43D RID: 107581
		[DllImport("Kitware.VTK.CommonExecutionModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkInformationExecutivePortKey_Get_01(HandleRef pThis, HandleRef info, HandleRef executive, ref int port);

		/// <summary>
		/// Get/Set the value associated with this key in the given
		/// information object.
		/// </summary>
		// Token: 0x0601A43E RID: 107582 RVA: 0x00247024 File Offset: 0x00245224
		public void Get(vtkInformation info, vtkExecutive executive, ref int port)
		{
			vtkInformationExecutivePortKey.vtkInformationExecutivePortKey_Get_01(base.GetCppThis(), (info == null) ? default(HandleRef) : info.GetCppThis(), (executive == null) ? default(HandleRef) : executive.GetCppThis(), ref port);
		}

		// Token: 0x0601A43F RID: 107583
		[DllImport("Kitware.VTK.CommonExecutionModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkInformationExecutivePortKey_GetExecutive_02(HandleRef pThis, HandleRef info, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Get/Set the value associated with this key in the given
		/// information object.
		/// </summary>
		// Token: 0x0601A440 RID: 107584 RVA: 0x0024706C File Offset: 0x0024526C
		public vtkExecutive GetExecutive(vtkInformation info)
		{
			vtkExecutive vtkExecutive = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkInformationExecutivePortKey.vtkInformationExecutivePortKey_GetExecutive_02(base.GetCppThis(), (info == null) ? default(HandleRef) : info.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkExecutive = (vtkExecutive)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkExecutive.Register(null);
				}
			}
			return vtkExecutive;
		}

		// Token: 0x0601A441 RID: 107585
		[DllImport("Kitware.VTK.CommonExecutionModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkInformationExecutivePortKey_GetNumberOfGenerationsFromBase_03(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601A442 RID: 107586 RVA: 0x002470F4 File Offset: 0x002452F4
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkInformationExecutivePortKey.vtkInformationExecutivePortKey_GetNumberOfGenerationsFromBase_03(base.GetCppThis(), type);
		}

		// Token: 0x0601A443 RID: 107587
		[DllImport("Kitware.VTK.CommonExecutionModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkInformationExecutivePortKey_GetNumberOfGenerationsFromBaseType_04([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601A444 RID: 107588 RVA: 0x00247114 File Offset: 0x00245314
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkInformationExecutivePortKey.vtkInformationExecutivePortKey_GetNumberOfGenerationsFromBaseType_04(type);
		}

		// Token: 0x0601A445 RID: 107589
		[DllImport("Kitware.VTK.CommonExecutionModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkInformationExecutivePortKey_GetPort_05(HandleRef pThis, HandleRef info);

		/// <summary>
		/// Get/Set the value associated with this key in the given
		/// information object.
		/// </summary>
		// Token: 0x0601A446 RID: 107590 RVA: 0x00247130 File Offset: 0x00245330
		public int GetPort(vtkInformation info)
		{
			return vtkInformationExecutivePortKey.vtkInformationExecutivePortKey_GetPort_05(base.GetCppThis(), (info == null) ? default(HandleRef) : info.GetCppThis());
		}

		// Token: 0x0601A447 RID: 107591
		[DllImport("Kitware.VTK.CommonExecutionModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkInformationExecutivePortKey_IsA_06(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601A448 RID: 107592 RVA: 0x00247164 File Offset: 0x00245364
		public override int IsA(string type)
		{
			return vtkInformationExecutivePortKey.vtkInformationExecutivePortKey_IsA_06(base.GetCppThis(), type);
		}

		// Token: 0x0601A449 RID: 107593
		[DllImport("Kitware.VTK.CommonExecutionModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkInformationExecutivePortKey_IsTypeOf_07([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601A44A RID: 107594 RVA: 0x00247184 File Offset: 0x00245384
		public new static int IsTypeOf(string type)
		{
			return vtkInformationExecutivePortKey.vtkInformationExecutivePortKey_IsTypeOf_07(type);
		}

		// Token: 0x0601A44B RID: 107595
		[DllImport("Kitware.VTK.CommonExecutionModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkInformationExecutivePortKey_MakeKey_08([MarshalAs(UnmanagedType.LPUTF8Str)] string name, [MarshalAs(UnmanagedType.LPUTF8Str)] string location, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// This method simply returns a new vtkInformationExecutivePortKey, given a
		/// name and a location. This method is provided for wrappers. Use the
		/// constructor directly from C++ instead.
		/// </summary>
		// Token: 0x0601A44C RID: 107596 RVA: 0x002471A0 File Offset: 0x002453A0
		public static vtkInformationExecutivePortKey MakeKey(string name, string location)
		{
			vtkInformationExecutivePortKey vtkInformationExecutivePortKey = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkInformationExecutivePortKey.vtkInformationExecutivePortKey_MakeKey_08(name, location, ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkInformationExecutivePortKey = (vtkInformationExecutivePortKey)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkInformationExecutivePortKey.Register(null);
				}
			}
			return vtkInformationExecutivePortKey;
		}

		// Token: 0x0601A44D RID: 107597
		[DllImport("Kitware.VTK.CommonExecutionModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkInformationExecutivePortKey_NewInstance_09(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601A44E RID: 107598 RVA: 0x0024720C File Offset: 0x0024540C
		public new vtkInformationExecutivePortKey NewInstance()
		{
			vtkInformationExecutivePortKey result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkInformationExecutivePortKey.vtkInformationExecutivePortKey_NewInstance_09(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkInformationExecutivePortKey)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x0601A44F RID: 107599
		[DllImport("Kitware.VTK.CommonExecutionModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkInformationExecutivePortKey_Report_10(HandleRef pThis, HandleRef info, HandleRef collector);

		/// <summary>
		/// Report a reference this key has in the given information object.
		/// </summary>
		// Token: 0x0601A450 RID: 107600 RVA: 0x00247268 File Offset: 0x00245468
		public override void Report(vtkInformation info, vtkGarbageCollector collector)
		{
			vtkInformationExecutivePortKey.vtkInformationExecutivePortKey_Report_10(base.GetCppThis(), (info == null) ? default(HandleRef) : info.GetCppThis(), (collector == null) ? default(HandleRef) : collector.GetCppThis());
		}

		// Token: 0x0601A451 RID: 107601
		[DllImport("Kitware.VTK.CommonExecutionModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkInformationExecutivePortKey_SafeDownCast_11(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601A452 RID: 107602 RVA: 0x002472AC File Offset: 0x002454AC
		public new static vtkInformationExecutivePortKey SafeDownCast(vtkObjectBase o)
		{
			vtkInformationExecutivePortKey vtkInformationExecutivePortKey = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkInformationExecutivePortKey.vtkInformationExecutivePortKey_SafeDownCast_11((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkInformationExecutivePortKey = (vtkInformationExecutivePortKey)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkInformationExecutivePortKey.Register(null);
				}
			}
			return vtkInformationExecutivePortKey;
		}

		// Token: 0x0601A453 RID: 107603
		[DllImport("Kitware.VTK.CommonExecutionModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkInformationExecutivePortKey_Set_12(HandleRef pThis, HandleRef info, HandleRef arg1, int arg2);

		/// <summary>
		/// Get/Set the value associated with this key in the given
		/// information object.
		/// </summary>
		// Token: 0x0601A454 RID: 107604 RVA: 0x0024732C File Offset: 0x0024552C
		public void Set(vtkInformation info, vtkExecutive arg1, int arg2)
		{
			vtkInformationExecutivePortKey.vtkInformationExecutivePortKey_Set_12(base.GetCppThis(), (info == null) ? default(HandleRef) : info.GetCppThis(), (arg1 == null) ? default(HandleRef) : arg1.GetCppThis(), arg2);
		}

		// Token: 0x0601A455 RID: 107605
		[DllImport("Kitware.VTK.CommonExecutionModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkInformationExecutivePortKey_ShallowCopy_13(HandleRef pThis, HandleRef from, HandleRef to);

		/// <summary>
		/// Copy the entry associated with this key from one information
		/// object to another.  If there is no entry in the first information
		/// object for this key, the value is removed from the second.
		/// </summary>
		// Token: 0x0601A456 RID: 107606 RVA: 0x00247374 File Offset: 0x00245574
		public override void ShallowCopy(vtkInformation from, vtkInformation to)
		{
			vtkInformationExecutivePortKey.vtkInformationExecutivePortKey_ShallowCopy_13(base.GetCppThis(), (from == null) ? default(HandleRef) : from.GetCppThis(), (to == null) ? default(HandleRef) : to.GetCppThis());
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001C84 RID: 7300
		public new const string MRFullTypeName = "Kitware.VTK.vtkInformationExecutivePortKey";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001C85 RID: 7301
		public new static readonly string MRClassNameKey = "class vtkInformationExecutivePortKey";
	}
}
