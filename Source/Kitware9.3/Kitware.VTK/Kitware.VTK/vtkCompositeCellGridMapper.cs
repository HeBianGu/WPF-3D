using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkCompositeCellGridMapper
	/// </summary>
	/// <remarks>
	///    a class that renders hierarchical cell-grid data
	///
	/// This class uses a vtkCellGridMapper to render input data
	/// which may be hierarchical. The input to this mapper may be
	/// either vtkCellGrid or a vtkCompositeDataSet built from
	/// cell-grids. If something other than vtkCellGrid is encountered,
	/// an error message will be produced.
	/// </remarks>
	/// <seealso>
	///
	/// vtkCellGridMapper
	/// </seealso>
	// Token: 0x020007D3 RID: 2003
	public class vtkCompositeCellGridMapper : vtkMapper
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x06014819 RID: 83993 RVA: 0x001D05F7 File Offset: 0x001CE7F7
		static vtkCompositeCellGridMapper()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkCompositeCellGridMapper.MRClassNameKey, Type.GetType("Kitware.VTK.vtkCompositeCellGridMapper"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x0601481A RID: 83994 RVA: 0x001D061F File Offset: 0x001CE81F
		public vtkCompositeCellGridMapper(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x0601481B RID: 83995
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkCompositeCellGridMapper_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601481C RID: 83996 RVA: 0x001D0630 File Offset: 0x001CE830
		public new static vtkCompositeCellGridMapper New()
		{
			vtkCompositeCellGridMapper result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkCompositeCellGridMapper.vtkCompositeCellGridMapper_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkCompositeCellGridMapper)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601481D RID: 83997 RVA: 0x001D0684 File Offset: 0x001CE884
		public vtkCompositeCellGridMapper() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkCompositeCellGridMapper.vtkCompositeCellGridMapper_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x0601481E RID: 83998 RVA: 0x001D06C8 File Offset: 0x001CE8C8
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x0601481F RID: 83999
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkCompositeCellGridMapper_GetBounds_01(HandleRef pThis);

		/// <summary>
		/// Standard vtkProp method to get 3D bounds of a 3D prop
		/// </summary>
		// Token: 0x06014820 RID: 84000 RVA: 0x001D06D4 File Offset: 0x001CE8D4
		public override double[] GetBounds()
		{
			IntPtr intPtr = vtkCompositeCellGridMapper.vtkCompositeCellGridMapper_GetBounds_01(base.GetCppThis());
			double[] array = null;
			if (IntPtr.Zero != intPtr)
			{
				array = new double[6];
				Marshal.Copy(intPtr, array, 0, array.Length);
			}
			return array;
		}

		// Token: 0x06014821 RID: 84001
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkCompositeCellGridMapper_GetBounds_02(HandleRef pThis, IntPtr bounds);

		/// <summary>
		/// Standard vtkProp method to get 3D bounds of a 3D prop
		/// </summary>
		// Token: 0x06014822 RID: 84002 RVA: 0x001D071C File Offset: 0x001CE91C
		public override void GetBounds(IntPtr bounds)
		{
			vtkCompositeCellGridMapper.vtkCompositeCellGridMapper_GetBounds_02(base.GetCppThis(), bounds);
		}

		// Token: 0x06014823 RID: 84003
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern vtkStringToken vtkCompositeCellGridMapper_GetCellIdAttributeName_03(HandleRef pThis);

		/// <summary>
		/// Some introspection on the type of data the mapper will render
		/// used by props to determine if they should invoke the mapper
		/// on a specific rendering pass.
		/// </summary>
		// Token: 0x06014824 RID: 84004 RVA: 0x001D072C File Offset: 0x001CE92C
		public virtual vtkStringToken GetCellIdAttributeName()
		{
			return vtkCompositeCellGridMapper.vtkCompositeCellGridMapper_GetCellIdAttributeName_03(base.GetCppThis());
		}

		// Token: 0x06014825 RID: 84005
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkCompositeCellGridMapper_GetCompositeDataDisplayAttributes_04(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Some introspection on the type of data the mapper will render
		/// used by props to determine if they should invoke the mapper
		/// on a specific rendering pass.
		/// </summary>
		// Token: 0x06014826 RID: 84006 RVA: 0x001D074C File Offset: 0x001CE94C
		public virtual vtkCompositeDataDisplayAttributes GetCompositeDataDisplayAttributes()
		{
			vtkCompositeDataDisplayAttributes vtkCompositeDataDisplayAttributes = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkCompositeCellGridMapper.vtkCompositeCellGridMapper_GetCompositeDataDisplayAttributes_04(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
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

		// Token: 0x06014827 RID: 84007
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern vtkStringToken vtkCompositeCellGridMapper_GetCompositeIdAttributeName_05(HandleRef pThis);

		/// <summary>
		/// Some introspection on the type of data the mapper will render
		/// used by props to determine if they should invoke the mapper
		/// on a specific rendering pass.
		/// </summary>
		// Token: 0x06014828 RID: 84008 RVA: 0x001D07BC File Offset: 0x001CE9BC
		public virtual vtkStringToken GetCompositeIdAttributeName()
		{
			return vtkCompositeCellGridMapper.vtkCompositeCellGridMapper_GetCompositeIdAttributeName_05(base.GetCppThis());
		}

		// Token: 0x06014829 RID: 84009
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern ulong vtkCompositeCellGridMapper_GetMTime_06(HandleRef pThis);

		/// <summary>
		/// Some introspection on the type of data the mapper will render
		/// used by props to determine if they should invoke the mapper
		/// on a specific rendering pass.
		/// </summary>
		// Token: 0x0601482A RID: 84010 RVA: 0x001D07DC File Offset: 0x001CE9DC
		public override ulong GetMTime()
		{
			return vtkCompositeCellGridMapper.vtkCompositeCellGridMapper_GetMTime_06(base.GetCppThis());
		}

		// Token: 0x0601482B RID: 84011
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkCompositeCellGridMapper_GetNumberOfGenerationsFromBase_07(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601482C RID: 84012 RVA: 0x001D07FC File Offset: 0x001CE9FC
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkCompositeCellGridMapper.vtkCompositeCellGridMapper_GetNumberOfGenerationsFromBase_07(base.GetCppThis(), type);
		}

		// Token: 0x0601482D RID: 84013
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkCompositeCellGridMapper_GetNumberOfGenerationsFromBaseType_08([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601482E RID: 84014 RVA: 0x001D081C File Offset: 0x001CEA1C
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkCompositeCellGridMapper.vtkCompositeCellGridMapper_GetNumberOfGenerationsFromBaseType_08(type);
		}

		// Token: 0x0601482F RID: 84015
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern vtkStringToken vtkCompositeCellGridMapper_GetPointIdAttributeName_09(HandleRef pThis);

		/// <summary>
		/// Some introspection on the type of data the mapper will render
		/// used by props to determine if they should invoke the mapper
		/// on a specific rendering pass.
		/// </summary>
		// Token: 0x06014830 RID: 84016 RVA: 0x001D0838 File Offset: 0x001CEA38
		public virtual vtkStringToken GetPointIdAttributeName()
		{
			return vtkCompositeCellGridMapper.vtkCompositeCellGridMapper_GetPointIdAttributeName_09(base.GetCppThis());
		}

		// Token: 0x06014831 RID: 84017
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern vtkStringToken vtkCompositeCellGridMapper_GetProcessIdAttributeName_10(HandleRef pThis);

		/// <summary>
		/// Some introspection on the type of data the mapper will render
		/// used by props to determine if they should invoke the mapper
		/// on a specific rendering pass.
		/// </summary>
		// Token: 0x06014832 RID: 84018 RVA: 0x001D0858 File Offset: 0x001CEA58
		public virtual vtkStringToken GetProcessIdAttributeName()
		{
			return vtkCompositeCellGridMapper.vtkCompositeCellGridMapper_GetProcessIdAttributeName_10(base.GetCppThis());
		}

		// Token: 0x06014833 RID: 84019
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkCompositeCellGridMapper_HasOpaqueGeometry_11(HandleRef pThis);

		/// <summary>
		/// Some introspection on the type of data the mapper will render
		/// used by props to determine if they should invoke the mapper
		/// on a specific rendering pass.
		/// </summary>
		// Token: 0x06014834 RID: 84020 RVA: 0x001D0878 File Offset: 0x001CEA78
		public override bool HasOpaqueGeometry()
		{
			return vtkCompositeCellGridMapper.vtkCompositeCellGridMapper_HasOpaqueGeometry_11(base.GetCppThis()) != 0;
		}

		// Token: 0x06014835 RID: 84021
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkCompositeCellGridMapper_HasTranslucentPolygonalGeometry_12(HandleRef pThis);

		/// <summary>
		/// Some introspection on the type of data the mapper will render
		/// used by props to determine if they should invoke the mapper
		/// on a specific rendering pass.
		/// </summary>
		// Token: 0x06014836 RID: 84022 RVA: 0x001D08A0 File Offset: 0x001CEAA0
		public override bool HasTranslucentPolygonalGeometry()
		{
			return vtkCompositeCellGridMapper.vtkCompositeCellGridMapper_HasTranslucentPolygonalGeometry_12(base.GetCppThis()) != 0;
		}

		// Token: 0x06014837 RID: 84023
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkCompositeCellGridMapper_IsA_13(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06014838 RID: 84024 RVA: 0x001D08C8 File Offset: 0x001CEAC8
		public override int IsA(string type)
		{
			return vtkCompositeCellGridMapper.vtkCompositeCellGridMapper_IsA_13(base.GetCppThis(), type);
		}

		// Token: 0x06014839 RID: 84025
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkCompositeCellGridMapper_IsTypeOf_14([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601483A RID: 84026 RVA: 0x001D08E8 File Offset: 0x001CEAE8
		public new static int IsTypeOf(string type)
		{
			return vtkCompositeCellGridMapper.vtkCompositeCellGridMapper_IsTypeOf_14(type);
		}

		// Token: 0x0601483B RID: 84027
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkCompositeCellGridMapper_NewInstance_16(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601483C RID: 84028 RVA: 0x001D0904 File Offset: 0x001CEB04
		public new vtkCompositeCellGridMapper NewInstance()
		{
			vtkCompositeCellGridMapper result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkCompositeCellGridMapper.vtkCompositeCellGridMapper_NewInstance_16(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkCompositeCellGridMapper)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x0601483D RID: 84029
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkCompositeCellGridMapper_RecursiveHasTranslucentGeometry_17(HandleRef pThis, HandleRef dobj, ref uint flat_index);

		/// <summary>
		/// Some introspection on the type of data the mapper will render
		/// used by props to determine if they should invoke the mapper
		/// on a specific rendering pass.
		/// </summary>
		// Token: 0x0601483E RID: 84030 RVA: 0x001D0960 File Offset: 0x001CEB60
		public bool RecursiveHasTranslucentGeometry(vtkDataObject dobj, ref uint flat_index)
		{
			return vtkCompositeCellGridMapper.vtkCompositeCellGridMapper_RecursiveHasTranslucentGeometry_17(base.GetCppThis(), (dobj == null) ? default(HandleRef) : dobj.GetCppThis(), ref flat_index) != 0;
		}

		// Token: 0x0601483F RID: 84031
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkCompositeCellGridMapper_ReleaseGraphicsResources_18(HandleRef pThis, HandleRef arg0);

		/// <summary>
		/// Release the underlying resources associated with this mapper
		/// </summary>
		// Token: 0x06014840 RID: 84032 RVA: 0x001D099C File Offset: 0x001CEB9C
		public override void ReleaseGraphicsResources(vtkWindow arg0)
		{
			vtkCompositeCellGridMapper.vtkCompositeCellGridMapper_ReleaseGraphicsResources_18(base.GetCppThis(), (arg0 == null) ? default(HandleRef) : arg0.GetCppThis());
		}

		// Token: 0x06014841 RID: 84033
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkCompositeCellGridMapper_Render_19(HandleRef pThis, HandleRef ren, HandleRef a);

		/// <summary>
		/// Standard method for rendering a mapper. This method will be
		/// called by the actor.
		/// </summary>
		// Token: 0x06014842 RID: 84034 RVA: 0x001D09CC File Offset: 0x001CEBCC
		public override void Render(vtkRenderer ren, vtkActor a)
		{
			vtkCompositeCellGridMapper.vtkCompositeCellGridMapper_Render_19(base.GetCppThis(), (ren == null) ? default(HandleRef) : ren.GetCppThis(), (a == null) ? default(HandleRef) : a.GetCppThis());
		}

		// Token: 0x06014843 RID: 84035
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkCompositeCellGridMapper_SafeDownCast_20(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06014844 RID: 84036 RVA: 0x001D0A10 File Offset: 0x001CEC10
		public new static vtkCompositeCellGridMapper SafeDownCast(vtkObjectBase o)
		{
			vtkCompositeCellGridMapper vtkCompositeCellGridMapper = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkCompositeCellGridMapper.vtkCompositeCellGridMapper_SafeDownCast_20((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkCompositeCellGridMapper = (vtkCompositeCellGridMapper)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkCompositeCellGridMapper.Register(null);
				}
			}
			return vtkCompositeCellGridMapper;
		}

		// Token: 0x06014845 RID: 84037
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkCompositeCellGridMapper_SetCellIdArrayName_21(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string arg0);

		/// <summary>
		/// Some introspection on the type of data the mapper will render
		/// used by props to determine if they should invoke the mapper
		/// on a specific rendering pass.
		/// </summary>
		// Token: 0x06014846 RID: 84038 RVA: 0x001D0A8F File Offset: 0x001CEC8F
		public void SetCellIdArrayName(string arg0)
		{
			vtkCompositeCellGridMapper.vtkCompositeCellGridMapper_SetCellIdArrayName_21(base.GetCppThis(), arg0);
		}

		// Token: 0x06014847 RID: 84039
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkCompositeCellGridMapper_SetCellIdAttributeName_22(HandleRef pThis, vtkStringToken _arg);

		/// <summary>
		/// Some introspection on the type of data the mapper will render
		/// used by props to determine if they should invoke the mapper
		/// on a specific rendering pass.
		/// </summary>
		// Token: 0x06014848 RID: 84040 RVA: 0x001D0A9F File Offset: 0x001CEC9F
		public virtual void SetCellIdAttributeName(vtkStringToken _arg)
		{
			vtkCompositeCellGridMapper.vtkCompositeCellGridMapper_SetCellIdAttributeName_22(base.GetCppThis(), _arg);
		}

		// Token: 0x06014849 RID: 84041
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkCompositeCellGridMapper_SetCompositeDataDisplayAttributes_23(HandleRef pThis, HandleRef arg0);

		/// <summary>
		/// Some introspection on the type of data the mapper will render
		/// used by props to determine if they should invoke the mapper
		/// on a specific rendering pass.
		/// </summary>
		// Token: 0x0601484A RID: 84042 RVA: 0x001D0AB0 File Offset: 0x001CECB0
		public virtual void SetCompositeDataDisplayAttributes(vtkCompositeDataDisplayAttributes arg0)
		{
			vtkCompositeCellGridMapper.vtkCompositeCellGridMapper_SetCompositeDataDisplayAttributes_23(base.GetCppThis(), (arg0 == null) ? default(HandleRef) : arg0.GetCppThis());
		}

		// Token: 0x0601484B RID: 84043
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkCompositeCellGridMapper_SetCompositeIdArrayName_24(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string arg0);

		/// <summary>
		/// Some introspection on the type of data the mapper will render
		/// used by props to determine if they should invoke the mapper
		/// on a specific rendering pass.
		/// </summary>
		// Token: 0x0601484C RID: 84044 RVA: 0x001D0ADF File Offset: 0x001CECDF
		public void SetCompositeIdArrayName(string arg0)
		{
			vtkCompositeCellGridMapper.vtkCompositeCellGridMapper_SetCompositeIdArrayName_24(base.GetCppThis(), arg0);
		}

		// Token: 0x0601484D RID: 84045
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkCompositeCellGridMapper_SetCompositeIdAttributeName_25(HandleRef pThis, vtkStringToken _arg);

		/// <summary>
		/// Some introspection on the type of data the mapper will render
		/// used by props to determine if they should invoke the mapper
		/// on a specific rendering pass.
		/// </summary>
		// Token: 0x0601484E RID: 84046 RVA: 0x001D0AEF File Offset: 0x001CECEF
		public virtual void SetCompositeIdAttributeName(vtkStringToken _arg)
		{
			vtkCompositeCellGridMapper.vtkCompositeCellGridMapper_SetCompositeIdAttributeName_25(base.GetCppThis(), _arg);
		}

		// Token: 0x0601484F RID: 84047
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkCompositeCellGridMapper_SetPointIdArrayName_26(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string arg0);

		/// <summary>
		/// Some introspection on the type of data the mapper will render
		/// used by props to determine if they should invoke the mapper
		/// on a specific rendering pass.
		/// </summary>
		// Token: 0x06014850 RID: 84048 RVA: 0x001D0AFF File Offset: 0x001CECFF
		public void SetPointIdArrayName(string arg0)
		{
			vtkCompositeCellGridMapper.vtkCompositeCellGridMapper_SetPointIdArrayName_26(base.GetCppThis(), arg0);
		}

		// Token: 0x06014851 RID: 84049
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkCompositeCellGridMapper_SetPointIdAttributeName_27(HandleRef pThis, vtkStringToken _arg);

		/// <summary>
		/// Some introspection on the type of data the mapper will render
		/// used by props to determine if they should invoke the mapper
		/// on a specific rendering pass.
		/// </summary>
		// Token: 0x06014852 RID: 84050 RVA: 0x001D0B0F File Offset: 0x001CED0F
		public virtual void SetPointIdAttributeName(vtkStringToken _arg)
		{
			vtkCompositeCellGridMapper.vtkCompositeCellGridMapper_SetPointIdAttributeName_27(base.GetCppThis(), _arg);
		}

		// Token: 0x06014853 RID: 84051
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkCompositeCellGridMapper_SetProcessIdArrayName_28(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string arg0);

		/// <summary>
		/// Some introspection on the type of data the mapper will render
		/// used by props to determine if they should invoke the mapper
		/// on a specific rendering pass.
		/// </summary>
		// Token: 0x06014854 RID: 84052 RVA: 0x001D0B1F File Offset: 0x001CED1F
		public void SetProcessIdArrayName(string arg0)
		{
			vtkCompositeCellGridMapper.vtkCompositeCellGridMapper_SetProcessIdArrayName_28(base.GetCppThis(), arg0);
		}

		// Token: 0x06014855 RID: 84053
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkCompositeCellGridMapper_SetProcessIdAttributeName_29(HandleRef pThis, vtkStringToken _arg);

		/// <summary>
		/// Some introspection on the type of data the mapper will render
		/// used by props to determine if they should invoke the mapper
		/// on a specific rendering pass.
		/// </summary>
		// Token: 0x06014856 RID: 84054 RVA: 0x001D0B2F File Offset: 0x001CED2F
		public virtual void SetProcessIdAttributeName(vtkStringToken _arg)
		{
			vtkCompositeCellGridMapper.vtkCompositeCellGridMapper_SetProcessIdAttributeName_29(base.GetCppThis(), _arg);
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x040017CC RID: 6092
		public new const string MRFullTypeName = "Kitware.VTK.vtkCompositeCellGridMapper";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x040017CD RID: 6093
		public new static readonly string MRClassNameKey = "class vtkCompositeCellGridMapper";
	}
}
