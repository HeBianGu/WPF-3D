using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///  vtkPassThrough
	/// </summary>
	/// <remarks>
	///  Pass input input data through to the output
	///
	/// vtkPassThrough simply passes input data to the output. By default, the input
	/// is shallow-copied (using `vtkDataObject::ShallowCopy`). If `DeepCopyInput` is true,
	/// then the input is deep-copied (using `vtkDataObject::DeepCopy`).
	///
	/// The output type is always the same as the input object type.
	/// </remarks>
	// Token: 0x02000416 RID: 1046
	public class vtkPassThrough : vtkPassInputTypeAlgorithm
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x0600C574 RID: 50548 RVA: 0x00112B0B File Offset: 0x00110D0B
		static vtkPassThrough()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkPassThrough.MRClassNameKey, Type.GetType("Kitware.VTK.vtkPassThrough"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x0600C575 RID: 50549 RVA: 0x00112B33 File Offset: 0x00110D33
		public vtkPassThrough(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x0600C576 RID: 50550
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkPassThrough_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600C577 RID: 50551 RVA: 0x00112B44 File Offset: 0x00110D44
		public new static vtkPassThrough New()
		{
			vtkPassThrough result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkPassThrough.vtkPassThrough_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkPassThrough)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600C578 RID: 50552 RVA: 0x00112B98 File Offset: 0x00110D98
		public vtkPassThrough() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkPassThrough.vtkPassThrough_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x0600C579 RID: 50553 RVA: 0x00112BDC File Offset: 0x00110DDC
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x0600C57A RID: 50554
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkPassThrough_AllowNullInputOff_01(HandleRef pThis);

		/// <summary>
		/// Allow the filter to execute without error when no input connection is
		/// specified. In this case, and empty vtkPolyData dataset will be created.
		/// By default, this setting is false.
		/// @{
		/// </summary>
		// Token: 0x0600C57B RID: 50555 RVA: 0x00112BE7 File Offset: 0x00110DE7
		public virtual void AllowNullInputOff()
		{
			vtkPassThrough.vtkPassThrough_AllowNullInputOff_01(base.GetCppThis());
		}

		// Token: 0x0600C57C RID: 50556
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkPassThrough_AllowNullInputOn_02(HandleRef pThis);

		/// <summary>
		/// Allow the filter to execute without error when no input connection is
		/// specified. In this case, and empty vtkPolyData dataset will be created.
		/// By default, this setting is false.
		/// @{
		/// </summary>
		// Token: 0x0600C57D RID: 50557 RVA: 0x00112BF6 File Offset: 0x00110DF6
		public virtual void AllowNullInputOn()
		{
			vtkPassThrough.vtkPassThrough_AllowNullInputOn_02(base.GetCppThis());
		}

		// Token: 0x0600C57E RID: 50558
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkPassThrough_DeepCopyInputOff_03(HandleRef pThis);

		/// <summary>
		/// Whether or not to deep copy the input. This can be useful if you
		/// want to create a copy of a data object. You can then disconnect
		/// this filter's input connections and it will act like a source.
		/// Defaults to OFF.
		/// </summary>
		// Token: 0x0600C57F RID: 50559 RVA: 0x00112C05 File Offset: 0x00110E05
		public virtual void DeepCopyInputOff()
		{
			vtkPassThrough.vtkPassThrough_DeepCopyInputOff_03(base.GetCppThis());
		}

		// Token: 0x0600C580 RID: 50560
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkPassThrough_DeepCopyInputOn_04(HandleRef pThis);

		/// <summary>
		/// Whether or not to deep copy the input. This can be useful if you
		/// want to create a copy of a data object. You can then disconnect
		/// this filter's input connections and it will act like a source.
		/// Defaults to OFF.
		/// </summary>
		// Token: 0x0600C581 RID: 50561 RVA: 0x00112C14 File Offset: 0x00110E14
		public virtual void DeepCopyInputOn()
		{
			vtkPassThrough.vtkPassThrough_DeepCopyInputOn_04(base.GetCppThis());
		}

		// Token: 0x0600C582 RID: 50562
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkPassThrough_FillInputPortInformation_05(HandleRef pThis, int port, HandleRef info);

		/// <summary>
		/// Specify the first input port as optional
		/// </summary>
		// Token: 0x0600C583 RID: 50563 RVA: 0x00112C24 File Offset: 0x00110E24
		public virtual int FillInputPortInformation(int port, vtkInformation info)
		{
			return vtkPassThrough.vtkPassThrough_FillInputPortInformation_05(base.GetCppThis(), port, (info == null) ? default(HandleRef) : info.GetCppThis());
		}

		// Token: 0x0600C584 RID: 50564
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkPassThrough_GetAllowNullInput_06(HandleRef pThis);

		/// <summary>
		/// Allow the filter to execute without error when no input connection is
		/// specified. In this case, and empty vtkPolyData dataset will be created.
		/// By default, this setting is false.
		/// @{
		/// </summary>
		// Token: 0x0600C585 RID: 50565 RVA: 0x00112C5C File Offset: 0x00110E5C
		public virtual bool GetAllowNullInput()
		{
			return vtkPassThrough.vtkPassThrough_GetAllowNullInput_06(base.GetCppThis()) != 0;
		}

		// Token: 0x0600C586 RID: 50566
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkPassThrough_GetDeepCopyInput_07(HandleRef pThis);

		/// <summary>
		/// Whether or not to deep copy the input. This can be useful if you
		/// want to create a copy of a data object. You can then disconnect
		/// this filter's input connections and it will act like a source.
		/// Defaults to OFF.
		/// </summary>
		// Token: 0x0600C587 RID: 50567 RVA: 0x00112C84 File Offset: 0x00110E84
		public virtual int GetDeepCopyInput()
		{
			return vtkPassThrough.vtkPassThrough_GetDeepCopyInput_07(base.GetCppThis());
		}

		// Token: 0x0600C588 RID: 50568
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkPassThrough_GetNumberOfGenerationsFromBase_08(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600C589 RID: 50569 RVA: 0x00112CA4 File Offset: 0x00110EA4
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkPassThrough.vtkPassThrough_GetNumberOfGenerationsFromBase_08(base.GetCppThis(), type);
		}

		// Token: 0x0600C58A RID: 50570
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkPassThrough_GetNumberOfGenerationsFromBaseType_09([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600C58B RID: 50571 RVA: 0x00112CC4 File Offset: 0x00110EC4
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkPassThrough.vtkPassThrough_GetNumberOfGenerationsFromBaseType_09(type);
		}

		// Token: 0x0600C58C RID: 50572
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkPassThrough_IsA_10(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600C58D RID: 50573 RVA: 0x00112CE0 File Offset: 0x00110EE0
		public override int IsA(string type)
		{
			return vtkPassThrough.vtkPassThrough_IsA_10(base.GetCppThis(), type);
		}

		// Token: 0x0600C58E RID: 50574
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkPassThrough_IsTypeOf_11([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600C58F RID: 50575 RVA: 0x00112D00 File Offset: 0x00110F00
		public new static int IsTypeOf(string type)
		{
			return vtkPassThrough.vtkPassThrough_IsTypeOf_11(type);
		}

		// Token: 0x0600C590 RID: 50576
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkPassThrough_NewInstance_13(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600C591 RID: 50577 RVA: 0x00112D1C File Offset: 0x00110F1C
		public new vtkPassThrough NewInstance()
		{
			vtkPassThrough result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkPassThrough.vtkPassThrough_NewInstance_13(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkPassThrough)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x0600C592 RID: 50578
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkPassThrough_SafeDownCast_14(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600C593 RID: 50579 RVA: 0x00112D78 File Offset: 0x00110F78
		public new static vtkPassThrough SafeDownCast(vtkObjectBase o)
		{
			vtkPassThrough vtkPassThrough = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkPassThrough.vtkPassThrough_SafeDownCast_14((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkPassThrough = (vtkPassThrough)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkPassThrough.Register(null);
				}
			}
			return vtkPassThrough;
		}

		// Token: 0x0600C594 RID: 50580
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkPassThrough_SetAllowNullInput_15(HandleRef pThis, byte _arg);

		/// <summary>
		/// Allow the filter to execute without error when no input connection is
		/// specified. In this case, and empty vtkPolyData dataset will be created.
		/// By default, this setting is false.
		/// @{
		/// </summary>
		// Token: 0x0600C595 RID: 50581 RVA: 0x00112DF7 File Offset: 0x00110FF7
		public virtual void SetAllowNullInput(bool _arg)
		{
			vtkPassThrough.vtkPassThrough_SetAllowNullInput_15(base.GetCppThis(), _arg ? (byte)1 : (byte)0);
		}

		// Token: 0x0600C596 RID: 50582
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkPassThrough_SetDeepCopyInput_16(HandleRef pThis, int _arg);

		/// <summary>
		/// Whether or not to deep copy the input. This can be useful if you
		/// want to create a copy of a data object. You can then disconnect
		/// this filter's input connections and it will act like a source.
		/// Defaults to OFF.
		/// </summary>
		// Token: 0x0600C597 RID: 50583 RVA: 0x00112E0F File Offset: 0x0011100F
		public virtual void SetDeepCopyInput(int _arg)
		{
			vtkPassThrough.vtkPassThrough_SetDeepCopyInput_16(base.GetCppThis(), _arg);
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04000EBC RID: 3772
		public new const string MRFullTypeName = "Kitware.VTK.vtkPassThrough";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04000EBD RID: 3773
		public new static readonly string MRClassNameKey = "class vtkPassThrough";
	}
}
