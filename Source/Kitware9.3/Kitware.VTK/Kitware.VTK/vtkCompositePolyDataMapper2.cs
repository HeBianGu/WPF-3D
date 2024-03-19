using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkCompositePolyDataMapper2
	/// </summary>
	/// <remarks>
	///    mapper for composite dataset consisting
	/// of polygonal data.
	///
	/// vtkCompositePolyDataMapper2 is similar to vtkCompositePolyDataMapper except
	/// that instead of creating individual mapper for each block in the composite
	/// dataset, it iterates over the blocks internally.
	/// </remarks>
	// Token: 0x0200057F RID: 1407
	public class vtkCompositePolyDataMapper2 : vtkOpenGLPolyDataMapper
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x0600F8EB RID: 63723 RVA: 0x00159FE7 File Offset: 0x001581E7
		static vtkCompositePolyDataMapper2()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkCompositePolyDataMapper2.MRClassNameKey, Type.GetType("Kitware.VTK.vtkCompositePolyDataMapper2"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x0600F8EC RID: 63724 RVA: 0x0015A00F File Offset: 0x0015820F
		public vtkCompositePolyDataMapper2(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x0600F8ED RID: 63725
		[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkCompositePolyDataMapper2_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600F8EE RID: 63726 RVA: 0x0015A020 File Offset: 0x00158220
		public new static vtkCompositePolyDataMapper2 New()
		{
			vtkCompositePolyDataMapper2 result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkCompositePolyDataMapper2.vtkCompositePolyDataMapper2_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkCompositePolyDataMapper2)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600F8EF RID: 63727 RVA: 0x0015A074 File Offset: 0x00158274
		public vtkCompositePolyDataMapper2() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkCompositePolyDataMapper2.vtkCompositePolyDataMapper2_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x0600F8F0 RID: 63728 RVA: 0x0015A0B8 File Offset: 0x001582B8
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x0600F8F1 RID: 63729
		[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkCompositePolyDataMapper2_ColorMissingArraysWithNanColorOff_01(HandleRef pThis);

		/// <summary>
		/// If the current 'color by' array is missing on some datasets, color these
		/// dataset by the LookupTable's NaN color, if the lookup table supports it.
		/// Default is false.
		/// @{
		/// </summary>
		// Token: 0x0600F8F2 RID: 63730 RVA: 0x0015A0C3 File Offset: 0x001582C3
		public virtual void ColorMissingArraysWithNanColorOff()
		{
			vtkCompositePolyDataMapper2.vtkCompositePolyDataMapper2_ColorMissingArraysWithNanColorOff_01(base.GetCppThis());
		}

		// Token: 0x0600F8F3 RID: 63731
		[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkCompositePolyDataMapper2_ColorMissingArraysWithNanColorOn_02(HandleRef pThis);

		/// <summary>
		/// If the current 'color by' array is missing on some datasets, color these
		/// dataset by the LookupTable's NaN color, if the lookup table supports it.
		/// Default is false.
		/// @{
		/// </summary>
		// Token: 0x0600F8F4 RID: 63732 RVA: 0x0015A0D2 File Offset: 0x001582D2
		public virtual void ColorMissingArraysWithNanColorOn()
		{
			vtkCompositePolyDataMapper2.vtkCompositePolyDataMapper2_ColorMissingArraysWithNanColorOn_02(base.GetCppThis());
		}

		// Token: 0x0600F8F5 RID: 63733
		[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkCompositePolyDataMapper2_GetBlockColor_03(HandleRef pThis, uint index);

		/// <summary>
		/// Set/get the color for a block given its flat index.
		/// </summary>
		// Token: 0x0600F8F6 RID: 63734 RVA: 0x0015A0E4 File Offset: 0x001582E4
		public IntPtr GetBlockColor(uint index)
		{
			return vtkCompositePolyDataMapper2.vtkCompositePolyDataMapper2_GetBlockColor_03(base.GetCppThis(), index);
		}

		// Token: 0x0600F8F7 RID: 63735
		[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkCompositePolyDataMapper2_GetBlockOpacity_04(HandleRef pThis, uint index);

		/// <summary>
		/// Set/get the opacity for a block given its flat index.
		/// </summary>
		// Token: 0x0600F8F8 RID: 63736 RVA: 0x0015A104 File Offset: 0x00158304
		public double GetBlockOpacity(uint index)
		{
			return vtkCompositePolyDataMapper2.vtkCompositePolyDataMapper2_GetBlockOpacity_04(base.GetCppThis(), index);
		}

		// Token: 0x0600F8F9 RID: 63737
		[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkCompositePolyDataMapper2_GetBlockVisibility_05(HandleRef pThis, uint index);

		/// <summary>
		/// Set/get the visibility for a block given its flat index.
		/// </summary>
		// Token: 0x0600F8FA RID: 63738 RVA: 0x0015A124 File Offset: 0x00158324
		public bool GetBlockVisibility(uint index)
		{
			return vtkCompositePolyDataMapper2.vtkCompositePolyDataMapper2_GetBlockVisibility_05(base.GetCppThis(), index) != 0;
		}

		// Token: 0x0600F8FB RID: 63739
		[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkCompositePolyDataMapper2_GetColorMissingArraysWithNanColor_06(HandleRef pThis);

		/// <summary>
		/// If the current 'color by' array is missing on some datasets, color these
		/// dataset by the LookupTable's NaN color, if the lookup table supports it.
		/// Default is false.
		/// @{
		/// </summary>
		// Token: 0x0600F8FC RID: 63740 RVA: 0x0015A14C File Offset: 0x0015834C
		public virtual bool GetColorMissingArraysWithNanColor()
		{
			return vtkCompositePolyDataMapper2.vtkCompositePolyDataMapper2_GetColorMissingArraysWithNanColor_06(base.GetCppThis()) != 0;
		}

		// Token: 0x0600F8FD RID: 63741
		[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkCompositePolyDataMapper2_GetCompositeDataDisplayAttributes_07(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Set/get the composite data set attributes.
		/// </summary>
		// Token: 0x0600F8FE RID: 63742 RVA: 0x0015A174 File Offset: 0x00158374
		public vtkCompositeDataDisplayAttributes GetCompositeDataDisplayAttributes()
		{
			vtkCompositeDataDisplayAttributes vtkCompositeDataDisplayAttributes = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkCompositePolyDataMapper2.vtkCompositePolyDataMapper2_GetCompositeDataDisplayAttributes_07(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
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

		// Token: 0x0600F8FF RID: 63743
		[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern ulong vtkCompositePolyDataMapper2_GetMTime_08(HandleRef pThis);

		/// <summary>
		/// Overridden to include vtkCompositeDataDisplayAttributes' mtime.
		/// </summary>
		// Token: 0x0600F900 RID: 63744 RVA: 0x0015A1E4 File Offset: 0x001583E4
		public override ulong GetMTime()
		{
			return vtkCompositePolyDataMapper2.vtkCompositePolyDataMapper2_GetMTime_08(base.GetCppThis());
		}

		// Token: 0x0600F901 RID: 63745
		[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkCompositePolyDataMapper2_GetNumberOfGenerationsFromBase_09(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600F902 RID: 63746 RVA: 0x0015A204 File Offset: 0x00158404
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkCompositePolyDataMapper2.vtkCompositePolyDataMapper2_GetNumberOfGenerationsFromBase_09(base.GetCppThis(), type);
		}

		// Token: 0x0600F903 RID: 63747
		[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkCompositePolyDataMapper2_GetNumberOfGenerationsFromBaseType_10([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600F904 RID: 63748 RVA: 0x0015A224 File Offset: 0x00158424
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkCompositePolyDataMapper2.vtkCompositePolyDataMapper2_GetNumberOfGenerationsFromBaseType_10(type);
		}

		// Token: 0x0600F905 RID: 63749
		[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkCompositePolyDataMapper2_HasOpaqueGeometry_11(HandleRef pThis);

		/// <summary>
		/// Some introspection on the type of data the mapper will render
		/// used by props to determine if they should invoke the mapper
		/// on a specific rendering pass.
		/// </summary>
		// Token: 0x0600F906 RID: 63750 RVA: 0x0015A240 File Offset: 0x00158440
		public override bool HasOpaqueGeometry()
		{
			return vtkCompositePolyDataMapper2.vtkCompositePolyDataMapper2_HasOpaqueGeometry_11(base.GetCppThis()) != 0;
		}

		// Token: 0x0600F907 RID: 63751
		[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkCompositePolyDataMapper2_HasTranslucentPolygonalGeometry_12(HandleRef pThis);

		/// <summary>
		/// Some introspection on the type of data the mapper will render
		/// used by props to determine if they should invoke the mapper
		/// on a specific rendering pass.
		/// </summary>
		// Token: 0x0600F908 RID: 63752 RVA: 0x0015A268 File Offset: 0x00158468
		public override bool HasTranslucentPolygonalGeometry()
		{
			return vtkCompositePolyDataMapper2.vtkCompositePolyDataMapper2_HasTranslucentPolygonalGeometry_12(base.GetCppThis()) != 0;
		}

		// Token: 0x0600F909 RID: 63753
		[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkCompositePolyDataMapper2_IsA_13(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600F90A RID: 63754 RVA: 0x0015A290 File Offset: 0x00158490
		public override int IsA(string type)
		{
			return vtkCompositePolyDataMapper2.vtkCompositePolyDataMapper2_IsA_13(base.GetCppThis(), type);
		}

		// Token: 0x0600F90B RID: 63755
		[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkCompositePolyDataMapper2_IsTypeOf_14([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600F90C RID: 63756 RVA: 0x0015A2B0 File Offset: 0x001584B0
		public new static int IsTypeOf(string type)
		{
			return vtkCompositePolyDataMapper2.vtkCompositePolyDataMapper2_IsTypeOf_14(type);
		}

		// Token: 0x0600F90D RID: 63757
		[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkCompositePolyDataMapper2_NewInstance_16(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600F90E RID: 63758 RVA: 0x0015A2CC File Offset: 0x001584CC
		public new vtkCompositePolyDataMapper2 NewInstance()
		{
			vtkCompositePolyDataMapper2 result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkCompositePolyDataMapper2.vtkCompositePolyDataMapper2_NewInstance_16(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkCompositePolyDataMapper2)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x0600F90F RID: 63759
		[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkCompositePolyDataMapper2_ReleaseGraphicsResources_17(HandleRef pThis, HandleRef arg0);

		/// <summary>
		/// Release any graphics resources that are being consumed by this mapper.
		/// The parameter window could be used to determine which graphic
		/// resources to release.
		/// </summary>
		// Token: 0x0600F910 RID: 63760 RVA: 0x0015A328 File Offset: 0x00158528
		public override void ReleaseGraphicsResources(vtkWindow arg0)
		{
			vtkCompositePolyDataMapper2.vtkCompositePolyDataMapper2_ReleaseGraphicsResources_17(base.GetCppThis(), (arg0 == null) ? default(HandleRef) : arg0.GetCppThis());
		}

		// Token: 0x0600F911 RID: 63761
		[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkCompositePolyDataMapper2_RemoveBlockColor_18(HandleRef pThis, uint index);

		/// <summary>
		/// Set/get the color for a block given its flat index.
		/// </summary>
		// Token: 0x0600F912 RID: 63762 RVA: 0x0015A357 File Offset: 0x00158557
		public void RemoveBlockColor(uint index)
		{
			vtkCompositePolyDataMapper2.vtkCompositePolyDataMapper2_RemoveBlockColor_18(base.GetCppThis(), index);
		}

		// Token: 0x0600F913 RID: 63763
		[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkCompositePolyDataMapper2_RemoveBlockColors_19(HandleRef pThis);

		/// <summary>
		/// Set/get the color for a block given its flat index.
		/// </summary>
		// Token: 0x0600F914 RID: 63764 RVA: 0x0015A367 File Offset: 0x00158567
		public void RemoveBlockColors()
		{
			vtkCompositePolyDataMapper2.vtkCompositePolyDataMapper2_RemoveBlockColors_19(base.GetCppThis());
		}

		// Token: 0x0600F915 RID: 63765
		[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkCompositePolyDataMapper2_RemoveBlockOpacities_20(HandleRef pThis);

		/// <summary>
		/// Set/get the opacity for a block given its flat index.
		/// </summary>
		// Token: 0x0600F916 RID: 63766 RVA: 0x0015A376 File Offset: 0x00158576
		public void RemoveBlockOpacities()
		{
			vtkCompositePolyDataMapper2.vtkCompositePolyDataMapper2_RemoveBlockOpacities_20(base.GetCppThis());
		}

		// Token: 0x0600F917 RID: 63767
		[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkCompositePolyDataMapper2_RemoveBlockOpacity_21(HandleRef pThis, uint index);

		/// <summary>
		/// Set/get the opacity for a block given its flat index.
		/// </summary>
		// Token: 0x0600F918 RID: 63768 RVA: 0x0015A385 File Offset: 0x00158585
		public void RemoveBlockOpacity(uint index)
		{
			vtkCompositePolyDataMapper2.vtkCompositePolyDataMapper2_RemoveBlockOpacity_21(base.GetCppThis(), index);
		}

		// Token: 0x0600F919 RID: 63769
		[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkCompositePolyDataMapper2_RemoveBlockVisibilities_22(HandleRef pThis);

		/// <summary>
		/// Set/get the visibility for a block given its flat index.
		/// </summary>
		// Token: 0x0600F91A RID: 63770 RVA: 0x0015A395 File Offset: 0x00158595
		public void RemoveBlockVisibilities()
		{
			vtkCompositePolyDataMapper2.vtkCompositePolyDataMapper2_RemoveBlockVisibilities_22(base.GetCppThis());
		}

		// Token: 0x0600F91B RID: 63771
		[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkCompositePolyDataMapper2_RemoveBlockVisibility_23(HandleRef pThis, uint index);

		/// <summary>
		/// Set/get the visibility for a block given its flat index.
		/// </summary>
		// Token: 0x0600F91C RID: 63772 RVA: 0x0015A3A4 File Offset: 0x001585A4
		public void RemoveBlockVisibility(uint index)
		{
			vtkCompositePolyDataMapper2.vtkCompositePolyDataMapper2_RemoveBlockVisibility_23(base.GetCppThis(), index);
		}

		// Token: 0x0600F91D RID: 63773
		[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkCompositePolyDataMapper2_Render_24(HandleRef pThis, HandleRef ren, HandleRef act);

		/// <summary>
		/// This calls RenderPiece (in a for loop if streaming is necessary).
		/// </summary>
		// Token: 0x0600F91E RID: 63774 RVA: 0x0015A3B4 File Offset: 0x001585B4
		public override void Render(vtkRenderer ren, vtkActor act)
		{
			vtkCompositePolyDataMapper2.vtkCompositePolyDataMapper2_Render_24(base.GetCppThis(), (ren == null) ? default(HandleRef) : ren.GetCppThis(), (act == null) ? default(HandleRef) : act.GetCppThis());
		}

		// Token: 0x0600F91F RID: 63775
		[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkCompositePolyDataMapper2_SafeDownCast_25(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600F920 RID: 63776 RVA: 0x0015A3F8 File Offset: 0x001585F8
		public new static vtkCompositePolyDataMapper2 SafeDownCast(vtkObjectBase o)
		{
			vtkCompositePolyDataMapper2 vtkCompositePolyDataMapper = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkCompositePolyDataMapper2.vtkCompositePolyDataMapper2_SafeDownCast_25((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkCompositePolyDataMapper = (vtkCompositePolyDataMapper2)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkCompositePolyDataMapper.Register(null);
				}
			}
			return vtkCompositePolyDataMapper;
		}

		// Token: 0x0600F921 RID: 63777
		[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkCompositePolyDataMapper2_SetBlockColor_26(HandleRef pThis, uint index, IntPtr color);

		/// <summary>
		/// Set/get the color for a block given its flat index.
		/// </summary>
		// Token: 0x0600F922 RID: 63778 RVA: 0x0015A477 File Offset: 0x00158677
		public void SetBlockColor(uint index, IntPtr color)
		{
			vtkCompositePolyDataMapper2.vtkCompositePolyDataMapper2_SetBlockColor_26(base.GetCppThis(), index, color);
		}

		// Token: 0x0600F923 RID: 63779
		[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkCompositePolyDataMapper2_SetBlockColor_27(HandleRef pThis, uint index, double r, double g, double b);

		/// <summary>
		/// Set/get the color for a block given its flat index.
		/// </summary>
		// Token: 0x0600F924 RID: 63780 RVA: 0x0015A488 File Offset: 0x00158688
		public void SetBlockColor(uint index, double r, double g, double b)
		{
			vtkCompositePolyDataMapper2.vtkCompositePolyDataMapper2_SetBlockColor_27(base.GetCppThis(), index, r, g, b);
		}

		// Token: 0x0600F925 RID: 63781
		[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkCompositePolyDataMapper2_SetBlockOpacity_28(HandleRef pThis, uint index, double opacity);

		/// <summary>
		/// Set/get the opacity for a block given its flat index.
		/// </summary>
		// Token: 0x0600F926 RID: 63782 RVA: 0x0015A49C File Offset: 0x0015869C
		public void SetBlockOpacity(uint index, double opacity)
		{
			vtkCompositePolyDataMapper2.vtkCompositePolyDataMapper2_SetBlockOpacity_28(base.GetCppThis(), index, opacity);
		}

		// Token: 0x0600F927 RID: 63783
		[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkCompositePolyDataMapper2_SetBlockVisibility_29(HandleRef pThis, uint index, byte visible);

		/// <summary>
		/// Set/get the visibility for a block given its flat index.
		/// </summary>
		// Token: 0x0600F928 RID: 63784 RVA: 0x0015A4AD File Offset: 0x001586AD
		public void SetBlockVisibility(uint index, bool visible)
		{
			vtkCompositePolyDataMapper2.vtkCompositePolyDataMapper2_SetBlockVisibility_29(base.GetCppThis(), index, visible ? (byte)1 : (byte)0);
		}

		// Token: 0x0600F929 RID: 63785
		[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkCompositePolyDataMapper2_SetColorMissingArraysWithNanColor_30(HandleRef pThis, byte _arg);

		/// <summary>
		/// If the current 'color by' array is missing on some datasets, color these
		/// dataset by the LookupTable's NaN color, if the lookup table supports it.
		/// Default is false.
		/// @{
		/// </summary>
		// Token: 0x0600F92A RID: 63786 RVA: 0x0015A4C6 File Offset: 0x001586C6
		public virtual void SetColorMissingArraysWithNanColor(bool _arg)
		{
			vtkCompositePolyDataMapper2.vtkCompositePolyDataMapper2_SetColorMissingArraysWithNanColor_30(base.GetCppThis(), _arg ? (byte)1 : (byte)0);
		}

		// Token: 0x0600F92B RID: 63787
		[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkCompositePolyDataMapper2_SetCompositeDataDisplayAttributes_31(HandleRef pThis, HandleRef attributes);

		/// <summary>
		/// Set/get the composite data set attributes.
		/// </summary>
		// Token: 0x0600F92C RID: 63788 RVA: 0x0015A4E0 File Offset: 0x001586E0
		public void SetCompositeDataDisplayAttributes(vtkCompositeDataDisplayAttributes attributes)
		{
			vtkCompositePolyDataMapper2.vtkCompositePolyDataMapper2_SetCompositeDataDisplayAttributes_31(base.GetCppThis(), (attributes == null) ? default(HandleRef) : attributes.GetCppThis());
		}

		// Token: 0x0600F92D RID: 63789
		[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkCompositePolyDataMapper2_SetInputArrayToProcess_32(HandleRef pThis, int idx, int port, int connection, int fieldAssociation, [MarshalAs(UnmanagedType.LPUTF8Str)] string name);

		/// <summary>
		/// Call SetInputArrayToProcess on helpers.
		/// </summary>
		// Token: 0x0600F92E RID: 63790 RVA: 0x0015A50F File Offset: 0x0015870F
		public override void SetInputArrayToProcess(int idx, int port, int connection, int fieldAssociation, string name)
		{
			vtkCompositePolyDataMapper2.vtkCompositePolyDataMapper2_SetInputArrayToProcess_32(base.GetCppThis(), idx, port, connection, fieldAssociation, name);
		}

		// Token: 0x0600F92F RID: 63791
		[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkCompositePolyDataMapper2_SetInputArrayToProcess_33(HandleRef pThis, int idx, int port, int connection, int fieldAssociation, int fieldAttributeType);

		/// <summary>
		/// Call SetInputArrayToProcess on helpers.
		/// </summary>
		// Token: 0x0600F930 RID: 63792 RVA: 0x0015A525 File Offset: 0x00158725
		public override void SetInputArrayToProcess(int idx, int port, int connection, int fieldAssociation, int fieldAttributeType)
		{
			vtkCompositePolyDataMapper2.vtkCompositePolyDataMapper2_SetInputArrayToProcess_33(base.GetCppThis(), idx, port, connection, fieldAssociation, fieldAttributeType);
		}

		// Token: 0x0600F931 RID: 63793
		[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkCompositePolyDataMapper2_SetInputArrayToProcess_34(HandleRef pThis, int idx, HandleRef info);

		/// <summary>
		/// Call SetInputArrayToProcess on helpers.
		/// </summary>
		// Token: 0x0600F932 RID: 63794 RVA: 0x0015A53C File Offset: 0x0015873C
		public override void SetInputArrayToProcess(int idx, vtkInformation info)
		{
			vtkCompositePolyDataMapper2.vtkCompositePolyDataMapper2_SetInputArrayToProcess_34(base.GetCppThis(), idx, (info == null) ? default(HandleRef) : info.GetCppThis());
		}

		// Token: 0x0600F933 RID: 63795
		[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkCompositePolyDataMapper2_SetPauseShiftScale_35(HandleRef pThis, byte pauseShiftScale);

		/// <summary>
		///
		/// This override passes the information to all instances in \a Helpers .
		/// </summary>
		// Token: 0x0600F934 RID: 63796 RVA: 0x0015A56C File Offset: 0x0015876C
		public override void SetPauseShiftScale(bool pauseShiftScale)
		{
			vtkCompositePolyDataMapper2.vtkCompositePolyDataMapper2_SetPauseShiftScale_35(base.GetCppThis(), pauseShiftScale ? (byte)1 : (byte)0);
		}

		// Token: 0x0600F935 RID: 63797
		[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkCompositePolyDataMapper2_SetVBOShiftScaleMethod_36(HandleRef pThis, int m);

		/// <summary>
		///   the VBO's shift+scale transform.
		/// </summary>
		// Token: 0x0600F936 RID: 63798 RVA: 0x0015A584 File Offset: 0x00158784
		public override void SetVBOShiftScaleMethod(int m)
		{
			vtkCompositePolyDataMapper2.vtkCompositePolyDataMapper2_SetVBOShiftScaleMethod_36(base.GetCppThis(), m);
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001217 RID: 4631
		public new const string MRFullTypeName = "Kitware.VTK.vtkCompositePolyDataMapper2";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001218 RID: 4632
		public new static readonly string MRClassNameKey = "class vtkCompositePolyDataMapper2";
	}
}
