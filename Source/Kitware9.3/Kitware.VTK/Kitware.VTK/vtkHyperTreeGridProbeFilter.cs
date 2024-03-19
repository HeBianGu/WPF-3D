using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkHyperTreeGridProbeFilter
	/// </summary>
	/// <remarks>
	///    Probe a vtkHyperTreeGrid
	///
	/// Heavily modeled after the vtkProbeFilter, this class
	///  is meant to be used to probe vtkHyperTreeGrid objects.
	///
	/// </remarks>
	// Token: 0x02000506 RID: 1286
	public class vtkHyperTreeGridProbeFilter : vtkDataSetAlgorithm
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x0600E716 RID: 59158 RVA: 0x00141DE3 File Offset: 0x0013FFE3
		static vtkHyperTreeGridProbeFilter()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkHyperTreeGridProbeFilter.MRClassNameKey, Type.GetType("Kitware.VTK.vtkHyperTreeGridProbeFilter"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x0600E717 RID: 59159 RVA: 0x00141E0B File Offset: 0x0014000B
		public vtkHyperTreeGridProbeFilter(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x0600E718 RID: 59160
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkHyperTreeGridProbeFilter_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600E719 RID: 59161 RVA: 0x00141E1C File Offset: 0x0014001C
		public new static vtkHyperTreeGridProbeFilter New()
		{
			vtkHyperTreeGridProbeFilter result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkHyperTreeGridProbeFilter.vtkHyperTreeGridProbeFilter_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkHyperTreeGridProbeFilter)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600E71A RID: 59162 RVA: 0x00141E70 File Offset: 0x00140070
		public vtkHyperTreeGridProbeFilter() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkHyperTreeGridProbeFilter.vtkHyperTreeGridProbeFilter_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x0600E71B RID: 59163 RVA: 0x00141EB4 File Offset: 0x001400B4
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x0600E71C RID: 59164
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkHyperTreeGridProbeFilter_GetComputeTolerance_01(HandleRef pThis);

		/// <summary>
		/// Get/Set whether or not to compute the tolerance automatically for
		/// when finding points in the HTG source. If false use the tolerance
		/// from SetTolerance .
		///
		/// Default is true
		/// </summary>
		// Token: 0x0600E71D RID: 59165 RVA: 0x00141EC0 File Offset: 0x001400C0
		public virtual bool GetComputeTolerance()
		{
			return vtkHyperTreeGridProbeFilter.vtkHyperTreeGridProbeFilter_GetComputeTolerance_01(base.GetCppThis()) != 0;
		}

		// Token: 0x0600E71E RID: 59166
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkHyperTreeGridProbeFilter_GetLocator_02(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Set and get the locator object
		/// </summary>
		// Token: 0x0600E71F RID: 59167 RVA: 0x00141EE8 File Offset: 0x001400E8
		public virtual vtkHyperTreeGridLocator GetLocator()
		{
			vtkHyperTreeGridLocator vtkHyperTreeGridLocator = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkHyperTreeGridProbeFilter.vtkHyperTreeGridProbeFilter_GetLocator_02(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkHyperTreeGridLocator = (vtkHyperTreeGridLocator)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkHyperTreeGridLocator.Register(null);
				}
			}
			return vtkHyperTreeGridLocator;
		}

		// Token: 0x0600E720 RID: 59168
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkHyperTreeGridProbeFilter_GetNumberOfGenerationsFromBase_03(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600E721 RID: 59169 RVA: 0x00141F58 File Offset: 0x00140158
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkHyperTreeGridProbeFilter.vtkHyperTreeGridProbeFilter_GetNumberOfGenerationsFromBase_03(base.GetCppThis(), type);
		}

		// Token: 0x0600E722 RID: 59170
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkHyperTreeGridProbeFilter_GetNumberOfGenerationsFromBaseType_04([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600E723 RID: 59171 RVA: 0x00141F78 File Offset: 0x00140178
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkHyperTreeGridProbeFilter.vtkHyperTreeGridProbeFilter_GetNumberOfGenerationsFromBaseType_04(type);
		}

		// Token: 0x0600E724 RID: 59172
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkHyperTreeGridProbeFilter_GetPassCellArrays_05(HandleRef pThis);

		/// <summary>
		/// Shallow copy the input cell data arrays to the output.
		/// Off by default.
		/// </summary>
		// Token: 0x0600E725 RID: 59173 RVA: 0x00141F94 File Offset: 0x00140194
		public virtual bool GetPassCellArrays()
		{
			return vtkHyperTreeGridProbeFilter.vtkHyperTreeGridProbeFilter_GetPassCellArrays_05(base.GetCppThis()) != 0;
		}

		// Token: 0x0600E726 RID: 59174
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkHyperTreeGridProbeFilter_GetPassFieldArrays_06(HandleRef pThis);

		/// <summary>
		/// Set whether to pass the field-data arrays from the Input i.e. the input
		/// providing the geometry to the output. On by default.
		/// </summary>
		// Token: 0x0600E727 RID: 59175 RVA: 0x00141FBC File Offset: 0x001401BC
		public virtual bool GetPassFieldArrays()
		{
			return vtkHyperTreeGridProbeFilter.vtkHyperTreeGridProbeFilter_GetPassFieldArrays_06(base.GetCppThis()) != 0;
		}

		// Token: 0x0600E728 RID: 59176
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkHyperTreeGridProbeFilter_GetPassPointArrays_07(HandleRef pThis);

		/// <summary>
		/// Shallow copy the input point data arrays to the output
		/// Off by default.
		/// </summary>
		// Token: 0x0600E729 RID: 59177 RVA: 0x00141FE4 File Offset: 0x001401E4
		public virtual bool GetPassPointArrays()
		{
			return vtkHyperTreeGridProbeFilter.vtkHyperTreeGridProbeFilter_GetPassPointArrays_07(base.GetCppThis()) != 0;
		}

		// Token: 0x0600E72A RID: 59178
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkHyperTreeGridProbeFilter_GetTolerance_08(HandleRef pThis);

		/// <summary>
		/// Get/Set tolerance used when finding points in the HTG source.
		/// Overridden when ComputeTolerance == true.
		///
		/// Default is 0.0
		/// </summary>
		// Token: 0x0600E72B RID: 59179 RVA: 0x0014200C File Offset: 0x0014020C
		public virtual double GetTolerance()
		{
			return vtkHyperTreeGridProbeFilter.vtkHyperTreeGridProbeFilter_GetTolerance_08(base.GetCppThis());
		}

		// Token: 0x0600E72C RID: 59180
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		[return: MarshalAs(UnmanagedType.LPUTF8Str)]
		internal static extern string vtkHyperTreeGridProbeFilter_GetValidPointMaskArrayName_09(HandleRef pThis);

		/// <summary>
		/// Returns the name of the char array added to the output with values 1 for
		/// valid points and 0 for invalid points.
		/// Set to "vtkValidPointMask" by default.
		/// </summary>
		// Token: 0x0600E72D RID: 59181 RVA: 0x0014202C File Offset: 0x0014022C
		public virtual string GetValidPointMaskArrayName()
		{
			return vtkHyperTreeGridProbeFilter.vtkHyperTreeGridProbeFilter_GetValidPointMaskArrayName_09(base.GetCppThis());
		}

		// Token: 0x0600E72E RID: 59182
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkHyperTreeGridProbeFilter_GetValidPoints_10(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Get the list of point ids in the output that contain attribute data
		/// from the source.
		/// </summary>
		// Token: 0x0600E72F RID: 59183 RVA: 0x0014204C File Offset: 0x0014024C
		public vtkIdTypeArray GetValidPoints()
		{
			vtkIdTypeArray vtkIdTypeArray = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkHyperTreeGridProbeFilter.vtkHyperTreeGridProbeFilter_GetValidPoints_10(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkIdTypeArray = (vtkIdTypeArray)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkIdTypeArray.Register(null);
				}
			}
			return vtkIdTypeArray;
		}

		// Token: 0x0600E730 RID: 59184
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkHyperTreeGridProbeFilter_IsA_11(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600E731 RID: 59185 RVA: 0x001420BC File Offset: 0x001402BC
		public override int IsA(string type)
		{
			return vtkHyperTreeGridProbeFilter.vtkHyperTreeGridProbeFilter_IsA_11(base.GetCppThis(), type);
		}

		// Token: 0x0600E732 RID: 59186
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkHyperTreeGridProbeFilter_IsTypeOf_12([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600E733 RID: 59187 RVA: 0x001420DC File Offset: 0x001402DC
		public new static int IsTypeOf(string type)
		{
			return vtkHyperTreeGridProbeFilter.vtkHyperTreeGridProbeFilter_IsTypeOf_12(type);
		}

		// Token: 0x0600E734 RID: 59188
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkHyperTreeGridProbeFilter_NewInstance_14(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600E735 RID: 59189 RVA: 0x001420F8 File Offset: 0x001402F8
		public new vtkHyperTreeGridProbeFilter NewInstance()
		{
			vtkHyperTreeGridProbeFilter result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkHyperTreeGridProbeFilter.vtkHyperTreeGridProbeFilter_NewInstance_14(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkHyperTreeGridProbeFilter)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x0600E736 RID: 59190
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkHyperTreeGridProbeFilter_PassCellArraysOff_15(HandleRef pThis);

		/// <summary>
		/// Shallow copy the input cell data arrays to the output.
		/// Off by default.
		/// </summary>
		// Token: 0x0600E737 RID: 59191 RVA: 0x00142152 File Offset: 0x00140352
		public virtual void PassCellArraysOff()
		{
			vtkHyperTreeGridProbeFilter.vtkHyperTreeGridProbeFilter_PassCellArraysOff_15(base.GetCppThis());
		}

		// Token: 0x0600E738 RID: 59192
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkHyperTreeGridProbeFilter_PassCellArraysOn_16(HandleRef pThis);

		/// <summary>
		/// Shallow copy the input cell data arrays to the output.
		/// Off by default.
		/// </summary>
		// Token: 0x0600E739 RID: 59193 RVA: 0x00142161 File Offset: 0x00140361
		public virtual void PassCellArraysOn()
		{
			vtkHyperTreeGridProbeFilter.vtkHyperTreeGridProbeFilter_PassCellArraysOn_16(base.GetCppThis());
		}

		// Token: 0x0600E73A RID: 59194
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkHyperTreeGridProbeFilter_PassFieldArraysOff_17(HandleRef pThis);

		/// <summary>
		/// Set whether to pass the field-data arrays from the Input i.e. the input
		/// providing the geometry to the output. On by default.
		/// </summary>
		// Token: 0x0600E73B RID: 59195 RVA: 0x00142170 File Offset: 0x00140370
		public virtual void PassFieldArraysOff()
		{
			vtkHyperTreeGridProbeFilter.vtkHyperTreeGridProbeFilter_PassFieldArraysOff_17(base.GetCppThis());
		}

		// Token: 0x0600E73C RID: 59196
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkHyperTreeGridProbeFilter_PassFieldArraysOn_18(HandleRef pThis);

		/// <summary>
		/// Set whether to pass the field-data arrays from the Input i.e. the input
		/// providing the geometry to the output. On by default.
		/// </summary>
		// Token: 0x0600E73D RID: 59197 RVA: 0x0014217F File Offset: 0x0014037F
		public virtual void PassFieldArraysOn()
		{
			vtkHyperTreeGridProbeFilter.vtkHyperTreeGridProbeFilter_PassFieldArraysOn_18(base.GetCppThis());
		}

		// Token: 0x0600E73E RID: 59198
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkHyperTreeGridProbeFilter_PassPointArraysOff_19(HandleRef pThis);

		/// <summary>
		/// Shallow copy the input point data arrays to the output
		/// Off by default.
		/// </summary>
		// Token: 0x0600E73F RID: 59199 RVA: 0x0014218E File Offset: 0x0014038E
		public virtual void PassPointArraysOff()
		{
			vtkHyperTreeGridProbeFilter.vtkHyperTreeGridProbeFilter_PassPointArraysOff_19(base.GetCppThis());
		}

		// Token: 0x0600E740 RID: 59200
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkHyperTreeGridProbeFilter_PassPointArraysOn_20(HandleRef pThis);

		/// <summary>
		/// Shallow copy the input point data arrays to the output
		/// Off by default.
		/// </summary>
		// Token: 0x0600E741 RID: 59201 RVA: 0x0014219D File Offset: 0x0014039D
		public virtual void PassPointArraysOn()
		{
			vtkHyperTreeGridProbeFilter.vtkHyperTreeGridProbeFilter_PassPointArraysOn_20(base.GetCppThis());
		}

		// Token: 0x0600E742 RID: 59202
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkHyperTreeGridProbeFilter_SafeDownCast_21(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600E743 RID: 59203 RVA: 0x001421AC File Offset: 0x001403AC
		public new static vtkHyperTreeGridProbeFilter SafeDownCast(vtkObjectBase o)
		{
			vtkHyperTreeGridProbeFilter vtkHyperTreeGridProbeFilter = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkHyperTreeGridProbeFilter.vtkHyperTreeGridProbeFilter_SafeDownCast_21((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkHyperTreeGridProbeFilter = (vtkHyperTreeGridProbeFilter)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkHyperTreeGridProbeFilter.Register(null);
				}
			}
			return vtkHyperTreeGridProbeFilter;
		}

		// Token: 0x0600E744 RID: 59204
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkHyperTreeGridProbeFilter_SetComputeTolerance_22(HandleRef pThis, byte _arg);

		/// <summary>
		/// Get/Set whether or not to compute the tolerance automatically for
		/// when finding points in the HTG source. If false use the tolerance
		/// from SetTolerance .
		///
		/// Default is true
		/// </summary>
		// Token: 0x0600E745 RID: 59205 RVA: 0x0014222B File Offset: 0x0014042B
		public virtual void SetComputeTolerance(bool _arg)
		{
			vtkHyperTreeGridProbeFilter.vtkHyperTreeGridProbeFilter_SetComputeTolerance_22(base.GetCppThis(), _arg ? (byte)1 : (byte)0);
		}

		// Token: 0x0600E746 RID: 59206
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkHyperTreeGridProbeFilter_SetLocator_23(HandleRef pThis, HandleRef arg0);

		/// <summary>
		/// Set and get the locator object
		/// </summary>
		// Token: 0x0600E747 RID: 59207 RVA: 0x00142244 File Offset: 0x00140444
		public virtual void SetLocator(vtkHyperTreeGridLocator arg0)
		{
			vtkHyperTreeGridProbeFilter.vtkHyperTreeGridProbeFilter_SetLocator_23(base.GetCppThis(), (arg0 == null) ? default(HandleRef) : arg0.GetCppThis());
		}

		// Token: 0x0600E748 RID: 59208
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkHyperTreeGridProbeFilter_SetPassCellArrays_24(HandleRef pThis, byte _arg);

		/// <summary>
		/// Shallow copy the input cell data arrays to the output.
		/// Off by default.
		/// </summary>
		// Token: 0x0600E749 RID: 59209 RVA: 0x00142273 File Offset: 0x00140473
		public virtual void SetPassCellArrays(bool _arg)
		{
			vtkHyperTreeGridProbeFilter.vtkHyperTreeGridProbeFilter_SetPassCellArrays_24(base.GetCppThis(), _arg ? (byte)1 : (byte)0);
		}

		// Token: 0x0600E74A RID: 59210
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkHyperTreeGridProbeFilter_SetPassFieldArrays_25(HandleRef pThis, byte _arg);

		/// <summary>
		/// Set whether to pass the field-data arrays from the Input i.e. the input
		/// providing the geometry to the output. On by default.
		/// </summary>
		// Token: 0x0600E74B RID: 59211 RVA: 0x0014228B File Offset: 0x0014048B
		public virtual void SetPassFieldArrays(bool _arg)
		{
			vtkHyperTreeGridProbeFilter.vtkHyperTreeGridProbeFilter_SetPassFieldArrays_25(base.GetCppThis(), _arg ? (byte)1 : (byte)0);
		}

		// Token: 0x0600E74C RID: 59212
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkHyperTreeGridProbeFilter_SetPassPointArrays_26(HandleRef pThis, byte _arg);

		/// <summary>
		/// Shallow copy the input point data arrays to the output
		/// Off by default.
		/// </summary>
		// Token: 0x0600E74D RID: 59213 RVA: 0x001422A3 File Offset: 0x001404A3
		public virtual void SetPassPointArrays(bool _arg)
		{
			vtkHyperTreeGridProbeFilter.vtkHyperTreeGridProbeFilter_SetPassPointArrays_26(base.GetCppThis(), _arg ? (byte)1 : (byte)0);
		}

		// Token: 0x0600E74E RID: 59214
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkHyperTreeGridProbeFilter_SetSourceConnection_27(HandleRef pThis, HandleRef algOutput);

		/// <summary>
		/// Specify the data set that will be probed at the input points.
		/// The Input gives the geometry (the points and cells) for the output,
		/// while the Source is probed (interpolated) to generate the scalars,
		/// vectors, etc. for the output points based on the point locations.
		/// </summary>
		// Token: 0x0600E74F RID: 59215 RVA: 0x001422BC File Offset: 0x001404BC
		public void SetSourceConnection(vtkAlgorithmOutput algOutput)
		{
			vtkHyperTreeGridProbeFilter.vtkHyperTreeGridProbeFilter_SetSourceConnection_27(base.GetCppThis(), (algOutput == null) ? default(HandleRef) : algOutput.GetCppThis());
		}

		// Token: 0x0600E750 RID: 59216
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkHyperTreeGridProbeFilter_SetTolerance_28(HandleRef pThis, double _arg);

		/// <summary>
		/// Get/Set tolerance used when finding points in the HTG source.
		/// Overridden when ComputeTolerance == true.
		///
		/// Default is 0.0
		/// </summary>
		// Token: 0x0600E751 RID: 59217 RVA: 0x001422EB File Offset: 0x001404EB
		public virtual void SetTolerance(double _arg)
		{
			vtkHyperTreeGridProbeFilter.vtkHyperTreeGridProbeFilter_SetTolerance_28(base.GetCppThis(), _arg);
		}

		// Token: 0x0600E752 RID: 59218
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkHyperTreeGridProbeFilter_SetValidPointMaskArrayName_29(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string _arg);

		/// <summary>
		/// Returns the name of the char array added to the output with values 1 for
		/// valid points and 0 for invalid points.
		/// Set to "vtkValidPointMask" by default.
		/// </summary>
		// Token: 0x0600E753 RID: 59219 RVA: 0x001422FB File Offset: 0x001404FB
		public virtual void SetValidPointMaskArrayName(string _arg)
		{
			vtkHyperTreeGridProbeFilter.vtkHyperTreeGridProbeFilter_SetValidPointMaskArrayName_29(base.GetCppThis(), _arg);
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x040010F3 RID: 4339
		public new const string MRFullTypeName = "Kitware.VTK.vtkHyperTreeGridProbeFilter";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x040010F4 RID: 4340
		public new static readonly string MRClassNameKey = "class vtkHyperTreeGridProbeFilter";
	}
}
