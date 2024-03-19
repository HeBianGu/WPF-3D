using System;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Text;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkCompositePolyDataMapper
	/// </summary>
	/// <remarks>
	///    a class that renders hierarchical polygonal data
	///
	/// This class uses a set of vtkPolyDataMappers to render input data
	/// which may be hierarchical. The input to this mapper may be
	/// either vtkPolyData or a vtkCompositeDataSet built from
	/// polydata. If something other than vtkPolyData is encountered,
	/// an error message will be produced.
	/// </remarks>
	/// <seealso>
	///
	/// vtkPolyDataMapper
	/// </seealso>
	// Token: 0x02000104 RID: 260
	public class vtkCompositePolyDataMapper : vtkPolyDataMapper
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x06003554 RID: 13652 RVA: 0x0004E00F File Offset: 0x0004C20F
		static vtkCompositePolyDataMapper()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkCompositePolyDataMapper.MRClassNameKey, Type.GetType("Kitware.VTK.vtkCompositePolyDataMapper"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x06003555 RID: 13653 RVA: 0x0004E037 File Offset: 0x0004C237
		public vtkCompositePolyDataMapper(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x06003556 RID: 13654
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkCompositePolyDataMapper_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06003557 RID: 13655 RVA: 0x0004E048 File Offset: 0x0004C248
		public new static vtkCompositePolyDataMapper New()
		{
			vtkCompositePolyDataMapper result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkCompositePolyDataMapper.vtkCompositePolyDataMapper_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkCompositePolyDataMapper)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06003558 RID: 13656 RVA: 0x0004E09C File Offset: 0x0004C29C
		public vtkCompositePolyDataMapper() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkCompositePolyDataMapper.vtkCompositePolyDataMapper_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x06003559 RID: 13657 RVA: 0x0004E0E0 File Offset: 0x0004C2E0
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x0600355A RID: 13658
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkCompositePolyDataMapper_ColorMissingArraysWithNanColorOff_01(HandleRef pThis);

		/// <summary>
		/// If the current 'color by' array is missing on some datasets, color these
		/// dataset by the LookupTable's NaN color, if the lookup table supports it.
		/// Default is false.
		///
		/// </summary>
		// Token: 0x0600355B RID: 13659 RVA: 0x0004E0EB File Offset: 0x0004C2EB
		public virtual void ColorMissingArraysWithNanColorOff()
		{
			vtkCompositePolyDataMapper.vtkCompositePolyDataMapper_ColorMissingArraysWithNanColorOff_01(base.GetCppThis());
		}

		// Token: 0x0600355C RID: 13660
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkCompositePolyDataMapper_ColorMissingArraysWithNanColorOn_02(HandleRef pThis);

		/// <summary>
		/// If the current 'color by' array is missing on some datasets, color these
		/// dataset by the LookupTable's NaN color, if the lookup table supports it.
		/// Default is false.
		///
		/// </summary>
		// Token: 0x0600355D RID: 13661 RVA: 0x0004E0FA File Offset: 0x0004C2FA
		public virtual void ColorMissingArraysWithNanColorOn()
		{
			vtkCompositePolyDataMapper.vtkCompositePolyDataMapper_ColorMissingArraysWithNanColorOn_02(base.GetCppThis());
		}

		// Token: 0x0600355E RID: 13662
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkCompositePolyDataMapper_GetBlockArrayAccessMode_03(HandleRef pThis, uint index);

		/// <summary>
		/// @see vtkMapper::SetArrayAccessMode
		/// </summary>
		// Token: 0x0600355F RID: 13663 RVA: 0x0004E10C File Offset: 0x0004C30C
		public int GetBlockArrayAccessMode(uint index)
		{
			return vtkCompositePolyDataMapper.vtkCompositePolyDataMapper_GetBlockArrayAccessMode_03(base.GetCppThis(), index);
		}

		// Token: 0x06003560 RID: 13664
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkCompositePolyDataMapper_GetBlockArrayComponent_04(HandleRef pThis, uint index);

		/// <summary>
		/// @see vtkMapper::SetArrayComponent
		/// </summary>
		// Token: 0x06003561 RID: 13665 RVA: 0x0004E12C File Offset: 0x0004C32C
		public int GetBlockArrayComponent(uint index)
		{
			return vtkCompositePolyDataMapper.vtkCompositePolyDataMapper_GetBlockArrayComponent_04(base.GetCppThis(), index);
		}

		// Token: 0x06003562 RID: 13666
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkCompositePolyDataMapper_GetBlockArrayId_05(HandleRef pThis, uint index);

		/// <summary>
		/// @see vtkMapper::SetArrayId
		/// </summary>
		// Token: 0x06003563 RID: 13667 RVA: 0x0004E14C File Offset: 0x0004C34C
		public int GetBlockArrayId(uint index)
		{
			return vtkCompositePolyDataMapper.vtkCompositePolyDataMapper_GetBlockArrayId_05(base.GetCppThis(), index);
		}

		// Token: 0x06003564 RID: 13668
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		[return: MarshalAs(UnmanagedType.LPUTF8Str)]
		internal static extern string vtkCompositePolyDataMapper_GetBlockArrayName_06(HandleRef pThis, uint index);

		/// <summary>
		/// @see vtkMapper::SetArrayName
		/// </summary>
		// Token: 0x06003565 RID: 13669 RVA: 0x0004E16C File Offset: 0x0004C36C
		public string GetBlockArrayName(uint index)
		{
			return vtkCompositePolyDataMapper.vtkCompositePolyDataMapper_GetBlockArrayName_06(base.GetCppThis(), index);
		}

		// Token: 0x06003566 RID: 13670
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkCompositePolyDataMapper_GetBlockColor_07(HandleRef pThis, uint index, IntPtr color);

		/// <summary>
		/// Set/get the color for a block given its flat index.
		/// </summary>
		// Token: 0x06003567 RID: 13671 RVA: 0x0004E18C File Offset: 0x0004C38C
		public void GetBlockColor(uint index, IntPtr color)
		{
			vtkCompositePolyDataMapper.vtkCompositePolyDataMapper_GetBlockColor_07(base.GetCppThis(), index, color);
		}

		// Token: 0x06003568 RID: 13672
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkCompositePolyDataMapper_GetBlockFieldDataTupleId_08(HandleRef pThis, uint index);

		/// <summary>
		/// @see vtkMapper::SetFieldDataTupleId
		/// </summary>
		// Token: 0x06003569 RID: 13673 RVA: 0x0004E1A0 File Offset: 0x0004C3A0
		public long GetBlockFieldDataTupleId(uint index)
		{
			return vtkCompositePolyDataMapper.vtkCompositePolyDataMapper_GetBlockFieldDataTupleId_08(base.GetCppThis(), index);
		}

		// Token: 0x0600356A RID: 13674
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkCompositePolyDataMapper_GetBlockOpacity_09(HandleRef pThis, uint index);

		/// <summary>
		/// Set/get the opacity for a block given its flat index.
		/// </summary>
		// Token: 0x0600356B RID: 13675 RVA: 0x0004E1C0 File Offset: 0x0004C3C0
		public double GetBlockOpacity(uint index)
		{
			return vtkCompositePolyDataMapper.vtkCompositePolyDataMapper_GetBlockOpacity_09(base.GetCppThis(), index);
		}

		// Token: 0x0600356C RID: 13676
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkCompositePolyDataMapper_GetBlockScalarMode_10(HandleRef pThis, uint index);

		/// <summary>
		/// @see vtkMapper::SetScalarMode
		/// </summary>
		// Token: 0x0600356D RID: 13677 RVA: 0x0004E1E0 File Offset: 0x0004C3E0
		public int GetBlockScalarMode(uint index)
		{
			return vtkCompositePolyDataMapper.vtkCompositePolyDataMapper_GetBlockScalarMode_10(base.GetCppThis(), index);
		}

		// Token: 0x0600356E RID: 13678
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkCompositePolyDataMapper_GetBlockVisibility_11(HandleRef pThis, uint index);

		/// <summary>
		/// Set/get the visibility for a block given its flat index.
		/// </summary>
		// Token: 0x0600356F RID: 13679 RVA: 0x0004E200 File Offset: 0x0004C400
		public bool GetBlockVisibility(uint index)
		{
			return vtkCompositePolyDataMapper.vtkCompositePolyDataMapper_GetBlockVisibility_11(base.GetCppThis(), index) != 0;
		}

		// Token: 0x06003570 RID: 13680
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkCompositePolyDataMapper_GetBounds_12(HandleRef pThis);

		/// <summary>
		/// Standard vtkProp method to get 3D bounds of a 3D prop
		/// </summary>
		// Token: 0x06003571 RID: 13681 RVA: 0x0004E228 File Offset: 0x0004C428
		public override double[] GetBounds()
		{
			IntPtr intPtr = vtkCompositePolyDataMapper.vtkCompositePolyDataMapper_GetBounds_12(base.GetCppThis());
			double[] array = null;
			if (IntPtr.Zero != intPtr)
			{
				array = new double[6];
				Marshal.Copy(intPtr, array, 0, array.Length);
			}
			return array;
		}

		// Token: 0x06003572 RID: 13682
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkCompositePolyDataMapper_GetBounds_13(HandleRef pThis, IntPtr bounds);

		/// <summary>
		/// Standard vtkProp method to get 3D bounds of a 3D prop
		/// </summary>
		// Token: 0x06003573 RID: 13683 RVA: 0x0004E270 File Offset: 0x0004C470
		public override void GetBounds(IntPtr bounds)
		{
			vtkCompositePolyDataMapper.vtkCompositePolyDataMapper_GetBounds_13(base.GetCppThis(), bounds);
		}

		// Token: 0x06003574 RID: 13684
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkCompositePolyDataMapper_GetCellIdArrayName_14(HandleRef pThis);

		/// <summary>
		/// By default, this class uses the dataset's point and cell ids during
		/// rendering. However, one can override those by specifying cell and point
		/// data arrays to use instead. Currently, only vtkIdType array is supported.
		/// Set to NULL string (default) to use the point ids instead.
		/// </summary>
		// Token: 0x06003575 RID: 13685 RVA: 0x0004E280 File Offset: 0x0004C480
		public virtual string GetCellIdArrayName()
		{
			string s = Marshal.PtrToStringAnsi(vtkCompositePolyDataMapper.vtkCompositePolyDataMapper_GetCellIdArrayName_14(base.GetCppThis()));
			return Encoding.UTF8.GetString(Encoding.Default.GetBytes(s));
		}

		// Token: 0x06003576 RID: 13686
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkCompositePolyDataMapper_GetColorMissingArraysWithNanColor_15(HandleRef pThis);

		/// <summary>
		/// If the current 'color by' array is missing on some datasets, color these
		/// dataset by the LookupTable's NaN color, if the lookup table supports it.
		/// Default is false.
		///
		/// </summary>
		// Token: 0x06003577 RID: 13687 RVA: 0x0004E2BC File Offset: 0x0004C4BC
		public virtual bool GetColorMissingArraysWithNanColor()
		{
			return vtkCompositePolyDataMapper.vtkCompositePolyDataMapper_GetColorMissingArraysWithNanColor_15(base.GetCppThis()) != 0;
		}

		// Token: 0x06003578 RID: 13688
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkCompositePolyDataMapper_GetCompositeDataDisplayAttributes_16(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Set/get the composite data set attributes.
		/// </summary>
		// Token: 0x06003579 RID: 13689 RVA: 0x0004E2E4 File Offset: 0x0004C4E4
		public vtkCompositeDataDisplayAttributes GetCompositeDataDisplayAttributes()
		{
			vtkCompositeDataDisplayAttributes vtkCompositeDataDisplayAttributes = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkCompositePolyDataMapper.vtkCompositePolyDataMapper_GetCompositeDataDisplayAttributes_16(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkCompositeDataDisplayAttributes = (vtkCompositeDataDisplayAttributes)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkCompositeDataDisplayAttributes.Register(null);
				}
			}
			return vtkCompositeDataDisplayAttributes;
		}

		// Token: 0x0600357A RID: 13690
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkCompositePolyDataMapper_GetCompositeIdArrayName_17(HandleRef pThis);

		/// <summary>
		/// Generally, this class can render the composite id when iterating
		/// over composite datasets. However in some cases (as in AMR), the rendered
		/// structure may not correspond to the input data, in which case we need
		/// to provide a cell array that can be used to render in the composite id in
		/// selection passes. Set to NULL (default) to not override the composite id
		/// color set by vtkCompositePainter if any.
		/// The array *MUST* be a cell array and of type vtkUnsignedIntArray.
		/// </summary>
		// Token: 0x0600357B RID: 13691 RVA: 0x0004E354 File Offset: 0x0004C554
		public virtual string GetCompositeIdArrayName()
		{
			string s = Marshal.PtrToStringAnsi(vtkCompositePolyDataMapper.vtkCompositePolyDataMapper_GetCompositeIdArrayName_17(base.GetCppThis()));
			return Encoding.UTF8.GetString(Encoding.Default.GetBytes(s));
		}

		// Token: 0x0600357C RID: 13692
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern ulong vtkCompositePolyDataMapper_GetMTime_18(HandleRef pThis);

		/// <summary>
		/// Overridden to include vtkCompositeDataDisplayAttributes' mtime.
		/// </summary>
		// Token: 0x0600357D RID: 13693 RVA: 0x0004E390 File Offset: 0x0004C590
		public override ulong GetMTime()
		{
			return vtkCompositePolyDataMapper.vtkCompositePolyDataMapper_GetMTime_18(base.GetCppThis());
		}

		// Token: 0x0600357E RID: 13694
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkCompositePolyDataMapper_GetNumberOfGenerationsFromBase_19(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600357F RID: 13695 RVA: 0x0004E3B0 File Offset: 0x0004C5B0
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkCompositePolyDataMapper.vtkCompositePolyDataMapper_GetNumberOfGenerationsFromBase_19(base.GetCppThis(), type);
		}

		// Token: 0x06003580 RID: 13696
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkCompositePolyDataMapper_GetNumberOfGenerationsFromBaseType_20([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06003581 RID: 13697 RVA: 0x0004E3D0 File Offset: 0x0004C5D0
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkCompositePolyDataMapper.vtkCompositePolyDataMapper_GetNumberOfGenerationsFromBaseType_20(type);
		}

		// Token: 0x06003582 RID: 13698
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkCompositePolyDataMapper_GetPointIdArrayName_21(HandleRef pThis);

		/// <summary>
		/// By default, this class uses the dataset's point and cell ids during
		/// rendering. However, one can override those by specifying cell and point
		/// data arrays to use instead. Currently, only vtkIdType array is supported.
		/// Set to NULL string (default) to use the point ids instead.
		/// </summary>
		// Token: 0x06003583 RID: 13699 RVA: 0x0004E3EC File Offset: 0x0004C5EC
		public virtual string GetPointIdArrayName()
		{
			string s = Marshal.PtrToStringAnsi(vtkCompositePolyDataMapper.vtkCompositePolyDataMapper_GetPointIdArrayName_21(base.GetCppThis()));
			return Encoding.UTF8.GetString(Encoding.Default.GetBytes(s));
		}

		// Token: 0x06003584 RID: 13700
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkCompositePolyDataMapper_GetProcessIdArrayName_22(HandleRef pThis);

		/// <summary>
		/// If this class should override the process id using a data-array,
		/// set this variable to the name of the array to use. It must be a
		/// point-array.
		/// </summary>
		// Token: 0x06003585 RID: 13701 RVA: 0x0004E428 File Offset: 0x0004C628
		public virtual string GetProcessIdArrayName()
		{
			string s = Marshal.PtrToStringAnsi(vtkCompositePolyDataMapper.vtkCompositePolyDataMapper_GetProcessIdArrayName_22(base.GetCppThis()));
			return Encoding.UTF8.GetString(Encoding.Default.GetBytes(s));
		}

		// Token: 0x06003586 RID: 13702
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkCompositePolyDataMapper_HasOpaqueGeometry_23(HandleRef pThis);

		/// <summary>
		/// Some introspection on the type of data the mapper will render
		/// used by props to determine if they should invoke the mapper
		/// on a specific rendering pass.
		/// </summary>
		// Token: 0x06003587 RID: 13703 RVA: 0x0004E464 File Offset: 0x0004C664
		public override bool HasOpaqueGeometry()
		{
			return vtkCompositePolyDataMapper.vtkCompositePolyDataMapper_HasOpaqueGeometry_23(base.GetCppThis()) != 0;
		}

		// Token: 0x06003588 RID: 13704
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkCompositePolyDataMapper_HasTranslucentPolygonalGeometry_24(HandleRef pThis);

		/// <summary>
		/// Some introspection on the type of data the mapper will render
		/// used by props to determine if they should invoke the mapper
		/// on a specific rendering pass.
		/// </summary>
		// Token: 0x06003589 RID: 13705 RVA: 0x0004E48C File Offset: 0x0004C68C
		public override bool HasTranslucentPolygonalGeometry()
		{
			return vtkCompositePolyDataMapper.vtkCompositePolyDataMapper_HasTranslucentPolygonalGeometry_24(base.GetCppThis()) != 0;
		}

		// Token: 0x0600358A RID: 13706
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkCompositePolyDataMapper_IsA_25(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600358B RID: 13707 RVA: 0x0004E4B4 File Offset: 0x0004C6B4
		public override int IsA(string type)
		{
			return vtkCompositePolyDataMapper.vtkCompositePolyDataMapper_IsA_25(base.GetCppThis(), type);
		}

		// Token: 0x0600358C RID: 13708
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkCompositePolyDataMapper_IsTypeOf_26([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600358D RID: 13709 RVA: 0x0004E4D4 File Offset: 0x0004C6D4
		public new static int IsTypeOf(string type)
		{
			return vtkCompositePolyDataMapper.vtkCompositePolyDataMapper_IsTypeOf_26(type);
		}

		// Token: 0x0600358E RID: 13710
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkCompositePolyDataMapper_NewInstance_28(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600358F RID: 13711 RVA: 0x0004E4F0 File Offset: 0x0004C6F0
		public new vtkCompositePolyDataMapper NewInstance()
		{
			vtkCompositePolyDataMapper result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkCompositePolyDataMapper.vtkCompositePolyDataMapper_NewInstance_28(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkCompositePolyDataMapper)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x06003590 RID: 13712
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkCompositePolyDataMapper_ReleaseGraphicsResources_29(HandleRef pThis, HandleRef arg0);

		/// <summary>
		/// Release the underlying resources associated with this mapper
		/// </summary>
		// Token: 0x06003591 RID: 13713 RVA: 0x0004E54C File Offset: 0x0004C74C
		public override void ReleaseGraphicsResources(vtkWindow arg0)
		{
			vtkCompositePolyDataMapper.vtkCompositePolyDataMapper_ReleaseGraphicsResources_29(base.GetCppThis(), (arg0 == null) ? default(HandleRef) : arg0.GetCppThis());
		}

		// Token: 0x06003592 RID: 13714
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkCompositePolyDataMapper_RemoveBlockArrayAccessMode_30(HandleRef pThis, uint index);

		/// <summary>
		/// @see vtkMapper::SetArrayAccessMode
		/// </summary>
		// Token: 0x06003593 RID: 13715 RVA: 0x0004E57B File Offset: 0x0004C77B
		public void RemoveBlockArrayAccessMode(uint index)
		{
			vtkCompositePolyDataMapper.vtkCompositePolyDataMapper_RemoveBlockArrayAccessMode_30(base.GetCppThis(), index);
		}

		// Token: 0x06003594 RID: 13716
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkCompositePolyDataMapper_RemoveBlockArrayAccessModes_31(HandleRef pThis);

		/// <summary>
		/// @see vtkMapper::SetArrayAccessMode
		/// </summary>
		// Token: 0x06003595 RID: 13717 RVA: 0x0004E58B File Offset: 0x0004C78B
		public void RemoveBlockArrayAccessModes()
		{
			vtkCompositePolyDataMapper.vtkCompositePolyDataMapper_RemoveBlockArrayAccessModes_31(base.GetCppThis());
		}

		// Token: 0x06003596 RID: 13718
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkCompositePolyDataMapper_RemoveBlockArrayComponent_32(HandleRef pThis, uint index);

		/// <summary>
		/// @see vtkMapper::SetArrayComponent
		/// </summary>
		// Token: 0x06003597 RID: 13719 RVA: 0x0004E59A File Offset: 0x0004C79A
		public void RemoveBlockArrayComponent(uint index)
		{
			vtkCompositePolyDataMapper.vtkCompositePolyDataMapper_RemoveBlockArrayComponent_32(base.GetCppThis(), index);
		}

		// Token: 0x06003598 RID: 13720
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkCompositePolyDataMapper_RemoveBlockArrayComponents_33(HandleRef pThis);

		/// <summary>
		/// @see vtkMapper::SetArrayComponent
		/// </summary>
		// Token: 0x06003599 RID: 13721 RVA: 0x0004E5AA File Offset: 0x0004C7AA
		public void RemoveBlockArrayComponents()
		{
			vtkCompositePolyDataMapper.vtkCompositePolyDataMapper_RemoveBlockArrayComponents_33(base.GetCppThis());
		}

		// Token: 0x0600359A RID: 13722
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkCompositePolyDataMapper_RemoveBlockArrayId_34(HandleRef pThis, uint index);

		/// <summary>
		/// @see vtkMapper::SetArrayId
		/// </summary>
		// Token: 0x0600359B RID: 13723 RVA: 0x0004E5B9 File Offset: 0x0004C7B9
		public void RemoveBlockArrayId(uint index)
		{
			vtkCompositePolyDataMapper.vtkCompositePolyDataMapper_RemoveBlockArrayId_34(base.GetCppThis(), index);
		}

		// Token: 0x0600359C RID: 13724
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkCompositePolyDataMapper_RemoveBlockArrayIds_35(HandleRef pThis);

		/// <summary>
		/// @see vtkMapper::SetArrayId
		/// </summary>
		// Token: 0x0600359D RID: 13725 RVA: 0x0004E5C9 File Offset: 0x0004C7C9
		public void RemoveBlockArrayIds()
		{
			vtkCompositePolyDataMapper.vtkCompositePolyDataMapper_RemoveBlockArrayIds_35(base.GetCppThis());
		}

		// Token: 0x0600359E RID: 13726
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkCompositePolyDataMapper_RemoveBlockArrayName_36(HandleRef pThis, uint index);

		/// <summary>
		/// @see vtkMapper::SetArrayName
		/// </summary>
		// Token: 0x0600359F RID: 13727 RVA: 0x0004E5D8 File Offset: 0x0004C7D8
		public void RemoveBlockArrayName(uint index)
		{
			vtkCompositePolyDataMapper.vtkCompositePolyDataMapper_RemoveBlockArrayName_36(base.GetCppThis(), index);
		}

		// Token: 0x060035A0 RID: 13728
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkCompositePolyDataMapper_RemoveBlockArrayNames_37(HandleRef pThis);

		/// <summary>
		/// @see vtkMapper::SetArrayName
		/// </summary>
		// Token: 0x060035A1 RID: 13729 RVA: 0x0004E5E8 File Offset: 0x0004C7E8
		public void RemoveBlockArrayNames()
		{
			vtkCompositePolyDataMapper.vtkCompositePolyDataMapper_RemoveBlockArrayNames_37(base.GetCppThis());
		}

		// Token: 0x060035A2 RID: 13730
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkCompositePolyDataMapper_RemoveBlockColor_38(HandleRef pThis, uint index);

		/// <summary>
		/// Set/get the color for a block given its flat index.
		/// </summary>
		// Token: 0x060035A3 RID: 13731 RVA: 0x0004E5F7 File Offset: 0x0004C7F7
		public void RemoveBlockColor(uint index)
		{
			vtkCompositePolyDataMapper.vtkCompositePolyDataMapper_RemoveBlockColor_38(base.GetCppThis(), index);
		}

		// Token: 0x060035A4 RID: 13732
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkCompositePolyDataMapper_RemoveBlockColors_39(HandleRef pThis);

		/// <summary>
		/// Set/get the color for a block given its flat index.
		/// </summary>
		// Token: 0x060035A5 RID: 13733 RVA: 0x0004E607 File Offset: 0x0004C807
		public void RemoveBlockColors()
		{
			vtkCompositePolyDataMapper.vtkCompositePolyDataMapper_RemoveBlockColors_39(base.GetCppThis());
		}

		// Token: 0x060035A6 RID: 13734
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkCompositePolyDataMapper_RemoveBlockFieldDataTupleId_40(HandleRef pThis, uint index);

		/// <summary>
		/// @see vtkMapper::SetFieldDataTupleId
		/// </summary>
		// Token: 0x060035A7 RID: 13735 RVA: 0x0004E616 File Offset: 0x0004C816
		public void RemoveBlockFieldDataTupleId(uint index)
		{
			vtkCompositePolyDataMapper.vtkCompositePolyDataMapper_RemoveBlockFieldDataTupleId_40(base.GetCppThis(), index);
		}

		// Token: 0x060035A8 RID: 13736
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkCompositePolyDataMapper_RemoveBlockFieldDataTupleIds_41(HandleRef pThis);

		/// <summary>
		/// @see vtkMapper::SetFieldDataTupleId
		/// </summary>
		// Token: 0x060035A9 RID: 13737 RVA: 0x0004E626 File Offset: 0x0004C826
		public void RemoveBlockFieldDataTupleIds()
		{
			vtkCompositePolyDataMapper.vtkCompositePolyDataMapper_RemoveBlockFieldDataTupleIds_41(base.GetCppThis());
		}

		// Token: 0x060035AA RID: 13738
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkCompositePolyDataMapper_RemoveBlockOpacities_42(HandleRef pThis);

		/// <summary>
		/// Set/get the opacity for a block given its flat index.
		/// </summary>
		// Token: 0x060035AB RID: 13739 RVA: 0x0004E635 File Offset: 0x0004C835
		public void RemoveBlockOpacities()
		{
			vtkCompositePolyDataMapper.vtkCompositePolyDataMapper_RemoveBlockOpacities_42(base.GetCppThis());
		}

		// Token: 0x060035AC RID: 13740
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkCompositePolyDataMapper_RemoveBlockOpacity_43(HandleRef pThis, uint index);

		/// <summary>
		/// Set/get the opacity for a block given its flat index.
		/// </summary>
		// Token: 0x060035AD RID: 13741 RVA: 0x0004E644 File Offset: 0x0004C844
		public void RemoveBlockOpacity(uint index)
		{
			vtkCompositePolyDataMapper.vtkCompositePolyDataMapper_RemoveBlockOpacity_43(base.GetCppThis(), index);
		}

		// Token: 0x060035AE RID: 13742
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkCompositePolyDataMapper_RemoveBlockScalarMode_44(HandleRef pThis, uint index);

		/// <summary>
		/// @see vtkMapper::SetScalarMode
		/// </summary>
		// Token: 0x060035AF RID: 13743 RVA: 0x0004E654 File Offset: 0x0004C854
		public void RemoveBlockScalarMode(uint index)
		{
			vtkCompositePolyDataMapper.vtkCompositePolyDataMapper_RemoveBlockScalarMode_44(base.GetCppThis(), index);
		}

		// Token: 0x060035B0 RID: 13744
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkCompositePolyDataMapper_RemoveBlockScalarModes_45(HandleRef pThis);

		/// <summary>
		/// @see vtkMapper::SetScalarMode
		/// </summary>
		// Token: 0x060035B1 RID: 13745 RVA: 0x0004E664 File Offset: 0x0004C864
		public void RemoveBlockScalarModes()
		{
			vtkCompositePolyDataMapper.vtkCompositePolyDataMapper_RemoveBlockScalarModes_45(base.GetCppThis());
		}

		// Token: 0x060035B2 RID: 13746
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkCompositePolyDataMapper_RemoveBlockVisibilities_46(HandleRef pThis);

		/// <summary>
		/// Set/get the visibility for a block given its flat index.
		/// </summary>
		// Token: 0x060035B3 RID: 13747 RVA: 0x0004E673 File Offset: 0x0004C873
		public void RemoveBlockVisibilities()
		{
			vtkCompositePolyDataMapper.vtkCompositePolyDataMapper_RemoveBlockVisibilities_46(base.GetCppThis());
		}

		// Token: 0x060035B4 RID: 13748
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkCompositePolyDataMapper_RemoveBlockVisibility_47(HandleRef pThis, uint index);

		/// <summary>
		/// Set/get the visibility for a block given its flat index.
		/// </summary>
		// Token: 0x060035B5 RID: 13749 RVA: 0x0004E682 File Offset: 0x0004C882
		public void RemoveBlockVisibility(uint index)
		{
			vtkCompositePolyDataMapper.vtkCompositePolyDataMapper_RemoveBlockVisibility_47(base.GetCppThis(), index);
		}

		// Token: 0x060035B6 RID: 13750
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkCompositePolyDataMapper_Render_48(HandleRef pThis, HandleRef renderer, HandleRef actor);

		/// <summary>
		/// Standard method for rendering a mapper. This method will be
		/// called by the actor.
		/// </summary>
		// Token: 0x060035B7 RID: 13751 RVA: 0x0004E694 File Offset: 0x0004C894
		public override void Render(vtkRenderer renderer, vtkActor actor)
		{
			vtkCompositePolyDataMapper.vtkCompositePolyDataMapper_Render_48(base.GetCppThis(), (renderer == null) ? default(HandleRef) : renderer.GetCppThis(), (actor == null) ? default(HandleRef) : actor.GetCppThis());
		}

		// Token: 0x060035B8 RID: 13752
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkCompositePolyDataMapper_SafeDownCast_49(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060035B9 RID: 13753 RVA: 0x0004E6D8 File Offset: 0x0004C8D8
		public new static vtkCompositePolyDataMapper SafeDownCast(vtkObjectBase o)
		{
			vtkCompositePolyDataMapper vtkCompositePolyDataMapper = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkCompositePolyDataMapper.vtkCompositePolyDataMapper_SafeDownCast_49((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkCompositePolyDataMapper = (vtkCompositePolyDataMapper)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkCompositePolyDataMapper.Register(null);
				}
			}
			return vtkCompositePolyDataMapper;
		}

		// Token: 0x060035BA RID: 13754
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkCompositePolyDataMapper_SetBlockArrayAccessMode_50(HandleRef pThis, uint index, int value);

		/// <summary>
		/// @see vtkMapper::SetArrayAccessMode
		/// </summary>
		// Token: 0x060035BB RID: 13755 RVA: 0x0004E757 File Offset: 0x0004C957
		public void SetBlockArrayAccessMode(uint index, int value)
		{
			vtkCompositePolyDataMapper.vtkCompositePolyDataMapper_SetBlockArrayAccessMode_50(base.GetCppThis(), index, value);
		}

		// Token: 0x060035BC RID: 13756
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkCompositePolyDataMapper_SetBlockArrayComponent_51(HandleRef pThis, uint index, int value);

		/// <summary>
		/// @see vtkMapper::SetArrayComponent
		/// </summary>
		// Token: 0x060035BD RID: 13757 RVA: 0x0004E768 File Offset: 0x0004C968
		public void SetBlockArrayComponent(uint index, int value)
		{
			vtkCompositePolyDataMapper.vtkCompositePolyDataMapper_SetBlockArrayComponent_51(base.GetCppThis(), index, value);
		}

		// Token: 0x060035BE RID: 13758
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkCompositePolyDataMapper_SetBlockArrayId_52(HandleRef pThis, uint index, int value);

		/// <summary>
		/// @see vtkMapper::SetArrayId
		/// </summary>
		// Token: 0x060035BF RID: 13759 RVA: 0x0004E779 File Offset: 0x0004C979
		public void SetBlockArrayId(uint index, int value)
		{
			vtkCompositePolyDataMapper.vtkCompositePolyDataMapper_SetBlockArrayId_52(base.GetCppThis(), index, value);
		}

		// Token: 0x060035C0 RID: 13760
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkCompositePolyDataMapper_SetBlockArrayName_53(HandleRef pThis, uint index, [MarshalAs(UnmanagedType.LPUTF8Str)] string value);

		/// <summary>
		/// @see vtkMapper::SetArrayName
		/// </summary>
		// Token: 0x060035C1 RID: 13761 RVA: 0x0004E78A File Offset: 0x0004C98A
		public void SetBlockArrayName(uint index, string value)
		{
			vtkCompositePolyDataMapper.vtkCompositePolyDataMapper_SetBlockArrayName_53(base.GetCppThis(), index, value);
		}

		// Token: 0x060035C2 RID: 13762
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkCompositePolyDataMapper_SetBlockColor_54(HandleRef pThis, uint index, IntPtr color);

		/// <summary>
		/// Set/get the color for a block given its flat index.
		/// </summary>
		// Token: 0x060035C3 RID: 13763 RVA: 0x0004E79B File Offset: 0x0004C99B
		public void SetBlockColor(uint index, IntPtr color)
		{
			vtkCompositePolyDataMapper.vtkCompositePolyDataMapper_SetBlockColor_54(base.GetCppThis(), index, color);
		}

		// Token: 0x060035C4 RID: 13764
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkCompositePolyDataMapper_SetBlockColor_55(HandleRef pThis, uint index, double r, double g, double b);

		/// <summary>
		/// Set/get the color for a block given its flat index.
		/// </summary>
		// Token: 0x060035C5 RID: 13765 RVA: 0x0004E7AC File Offset: 0x0004C9AC
		public void SetBlockColor(uint index, double r, double g, double b)
		{
			vtkCompositePolyDataMapper.vtkCompositePolyDataMapper_SetBlockColor_55(base.GetCppThis(), index, r, g, b);
		}

		// Token: 0x060035C6 RID: 13766
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkCompositePolyDataMapper_SetBlockFieldDataTupleId_56(HandleRef pThis, uint index, long value);

		/// <summary>
		/// @see vtkMapper::SetFieldDataTupleId
		/// </summary>
		// Token: 0x060035C7 RID: 13767 RVA: 0x0004E7C0 File Offset: 0x0004C9C0
		public void SetBlockFieldDataTupleId(uint index, long value)
		{
			vtkCompositePolyDataMapper.vtkCompositePolyDataMapper_SetBlockFieldDataTupleId_56(base.GetCppThis(), index, value);
		}

		// Token: 0x060035C8 RID: 13768
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkCompositePolyDataMapper_SetBlockOpacity_57(HandleRef pThis, uint index, double opacity);

		/// <summary>
		/// Set/get the opacity for a block given its flat index.
		/// </summary>
		// Token: 0x060035C9 RID: 13769 RVA: 0x0004E7D1 File Offset: 0x0004C9D1
		public void SetBlockOpacity(uint index, double opacity)
		{
			vtkCompositePolyDataMapper.vtkCompositePolyDataMapper_SetBlockOpacity_57(base.GetCppThis(), index, opacity);
		}

		// Token: 0x060035CA RID: 13770
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkCompositePolyDataMapper_SetBlockScalarMode_58(HandleRef pThis, uint index, int value);

		/// <summary>
		/// @see vtkMapper::SetScalarMode
		/// </summary>
		// Token: 0x060035CB RID: 13771 RVA: 0x0004E7E2 File Offset: 0x0004C9E2
		public void SetBlockScalarMode(uint index, int value)
		{
			vtkCompositePolyDataMapper.vtkCompositePolyDataMapper_SetBlockScalarMode_58(base.GetCppThis(), index, value);
		}

		// Token: 0x060035CC RID: 13772
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkCompositePolyDataMapper_SetBlockVisibility_59(HandleRef pThis, uint index, byte visible);

		/// <summary>
		/// Set/get the visibility for a block given its flat index.
		/// </summary>
		// Token: 0x060035CD RID: 13773 RVA: 0x0004E7F3 File Offset: 0x0004C9F3
		public void SetBlockVisibility(uint index, bool visible)
		{
			vtkCompositePolyDataMapper.vtkCompositePolyDataMapper_SetBlockVisibility_59(base.GetCppThis(), index, visible ? (byte)1 : (byte)0);
		}

		// Token: 0x060035CE RID: 13774
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkCompositePolyDataMapper_SetCellIdArrayName_60(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string _arg);

		/// <summary>
		/// By default, this class uses the dataset's point and cell ids during
		/// rendering. However, one can override those by specifying cell and point
		/// data arrays to use instead. Currently, only vtkIdType array is supported.
		/// Set to NULL string (default) to use the point ids instead.
		/// </summary>
		// Token: 0x060035CF RID: 13775 RVA: 0x0004E80C File Offset: 0x0004CA0C
		public virtual void SetCellIdArrayName(string _arg)
		{
			vtkCompositePolyDataMapper.vtkCompositePolyDataMapper_SetCellIdArrayName_60(base.GetCppThis(), _arg);
		}

		// Token: 0x060035D0 RID: 13776
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkCompositePolyDataMapper_SetColorMissingArraysWithNanColor_61(HandleRef pThis, byte _arg);

		/// <summary>
		/// If the current 'color by' array is missing on some datasets, color these
		/// dataset by the LookupTable's NaN color, if the lookup table supports it.
		/// Default is false.
		///
		/// </summary>
		// Token: 0x060035D1 RID: 13777 RVA: 0x0004E81C File Offset: 0x0004CA1C
		public virtual void SetColorMissingArraysWithNanColor(bool _arg)
		{
			vtkCompositePolyDataMapper.vtkCompositePolyDataMapper_SetColorMissingArraysWithNanColor_61(base.GetCppThis(), _arg ? (byte)1 : (byte)0);
		}

		// Token: 0x060035D2 RID: 13778
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkCompositePolyDataMapper_SetCompositeDataDisplayAttributes_62(HandleRef pThis, HandleRef attributes);

		/// <summary>
		/// Set/get the composite data set attributes.
		/// </summary>
		// Token: 0x060035D3 RID: 13779 RVA: 0x0004E834 File Offset: 0x0004CA34
		public void SetCompositeDataDisplayAttributes(vtkCompositeDataDisplayAttributes attributes)
		{
			vtkCompositePolyDataMapper.vtkCompositePolyDataMapper_SetCompositeDataDisplayAttributes_62(base.GetCppThis(), (attributes == null) ? default(HandleRef) : attributes.GetCppThis());
		}

		// Token: 0x060035D4 RID: 13780
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkCompositePolyDataMapper_SetCompositeIdArrayName_63(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string _arg);

		/// <summary>
		/// Generally, this class can render the composite id when iterating
		/// over composite datasets. However in some cases (as in AMR), the rendered
		/// structure may not correspond to the input data, in which case we need
		/// to provide a cell array that can be used to render in the composite id in
		/// selection passes. Set to NULL (default) to not override the composite id
		/// color set by vtkCompositePainter if any.
		/// The array *MUST* be a cell array and of type vtkUnsignedIntArray.
		/// </summary>
		// Token: 0x060035D5 RID: 13781 RVA: 0x0004E863 File Offset: 0x0004CA63
		public virtual void SetCompositeIdArrayName(string _arg)
		{
			vtkCompositePolyDataMapper.vtkCompositePolyDataMapper_SetCompositeIdArrayName_63(base.GetCppThis(), _arg);
		}

		// Token: 0x060035D6 RID: 13782
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkCompositePolyDataMapper_SetInputArrayToProcess_64(HandleRef pThis, int idx, int port, int connection, int fieldAssociation, [MarshalAs(UnmanagedType.LPUTF8Str)] string name);

		/// <summary>
		/// Call SetInputArrayToProcess on helpers.
		/// </summary>
		// Token: 0x060035D7 RID: 13783 RVA: 0x0004E873 File Offset: 0x0004CA73
		public override void SetInputArrayToProcess(int idx, int port, int connection, int fieldAssociation, string name)
		{
			vtkCompositePolyDataMapper.vtkCompositePolyDataMapper_SetInputArrayToProcess_64(base.GetCppThis(), idx, port, connection, fieldAssociation, name);
		}

		// Token: 0x060035D8 RID: 13784
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkCompositePolyDataMapper_SetInputArrayToProcess_65(HandleRef pThis, int idx, int port, int connection, int fieldAssociation, int fieldAttributeType);

		/// <summary>
		/// Call SetInputArrayToProcess on helpers.
		/// </summary>
		// Token: 0x060035D9 RID: 13785 RVA: 0x0004E889 File Offset: 0x0004CA89
		public override void SetInputArrayToProcess(int idx, int port, int connection, int fieldAssociation, int fieldAttributeType)
		{
			vtkCompositePolyDataMapper.vtkCompositePolyDataMapper_SetInputArrayToProcess_65(base.GetCppThis(), idx, port, connection, fieldAssociation, fieldAttributeType);
		}

		// Token: 0x060035DA RID: 13786
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkCompositePolyDataMapper_SetInputArrayToProcess_66(HandleRef pThis, int idx, HandleRef info);

		/// <summary>
		/// Call SetInputArrayToProcess on helpers.
		/// </summary>
		// Token: 0x060035DB RID: 13787 RVA: 0x0004E8A0 File Offset: 0x0004CAA0
		public override void SetInputArrayToProcess(int idx, vtkInformation info)
		{
			vtkCompositePolyDataMapper.vtkCompositePolyDataMapper_SetInputArrayToProcess_66(base.GetCppThis(), idx, (info == null) ? default(HandleRef) : info.GetCppThis());
		}

		// Token: 0x060035DC RID: 13788
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkCompositePolyDataMapper_SetPauseShiftScale_67(HandleRef pThis, byte pauseShiftScale);

		/// <summary>
		/// Pause updates of shift-scale parameters based on camera position.
		///
		/// This override passes the information to all instances in \a Helpers .
		/// </summary>
		// Token: 0x060035DD RID: 13789 RVA: 0x0004E8D0 File Offset: 0x0004CAD0
		public override void SetPauseShiftScale(bool pauseShiftScale)
		{
			vtkCompositePolyDataMapper.vtkCompositePolyDataMapper_SetPauseShiftScale_67(base.GetCppThis(), pauseShiftScale ? (byte)1 : (byte)0);
		}

		// Token: 0x060035DE RID: 13790
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkCompositePolyDataMapper_SetPointIdArrayName_68(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string _arg);

		/// <summary>
		/// By default, this class uses the dataset's point and cell ids during
		/// rendering. However, one can override those by specifying cell and point
		/// data arrays to use instead. Currently, only vtkIdType array is supported.
		/// Set to NULL string (default) to use the point ids instead.
		/// </summary>
		// Token: 0x060035DF RID: 13791 RVA: 0x0004E8E8 File Offset: 0x0004CAE8
		public virtual void SetPointIdArrayName(string _arg)
		{
			vtkCompositePolyDataMapper.vtkCompositePolyDataMapper_SetPointIdArrayName_68(base.GetCppThis(), _arg);
		}

		// Token: 0x060035E0 RID: 13792
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkCompositePolyDataMapper_SetProcessIdArrayName_69(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string _arg);

		/// <summary>
		/// If this class should override the process id using a data-array,
		/// set this variable to the name of the array to use. It must be a
		/// point-array.
		/// </summary>
		// Token: 0x060035E1 RID: 13793 RVA: 0x0004E8F8 File Offset: 0x0004CAF8
		public virtual void SetProcessIdArrayName(string _arg)
		{
			vtkCompositePolyDataMapper.vtkCompositePolyDataMapper_SetProcessIdArrayName_69(base.GetCppThis(), _arg);
		}

		// Token: 0x060035E2 RID: 13794
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkCompositePolyDataMapper_SetVBOShiftScaleMethod_70(HandleRef pThis, int method);

		/// <summary>
		/// A convenience method for enabling/disabling  the VBO's shift+scale transform.
		/// </summary>
		// Token: 0x060035E3 RID: 13795 RVA: 0x0004E908 File Offset: 0x0004CB08
		public override void SetVBOShiftScaleMethod(int method)
		{
			vtkCompositePolyDataMapper.vtkCompositePolyDataMapper_SetVBOShiftScaleMethod_70(base.GetCppThis(), method);
		}

		// Token: 0x060035E4 RID: 13796
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkCompositePolyDataMapper_ShallowCopy_71(HandleRef pThis, HandleRef mapper);

		/// <summary>
		/// Make a shallow copy of this mapper.
		/// </summary>
		// Token: 0x060035E5 RID: 13797 RVA: 0x0004E918 File Offset: 0x0004CB18
		public override void ShallowCopy(vtkAbstractMapper mapper)
		{
			vtkCompositePolyDataMapper.vtkCompositePolyDataMapper_ShallowCopy_71(base.GetCppThis(), (mapper == null) ? default(HandleRef) : mapper.GetCppThis());
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04000640 RID: 1600
		public new const string MRFullTypeName = "Kitware.VTK.vtkCompositePolyDataMapper";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04000641 RID: 1601
		public new static readonly string MRClassNameKey = "class vtkCompositePolyDataMapper";
	}
}
