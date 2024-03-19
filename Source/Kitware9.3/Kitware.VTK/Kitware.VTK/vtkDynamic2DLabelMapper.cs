using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkDynamic2DLabelMapper
	/// </summary>
	/// <remarks>
	///    draw text labels at 2D dataset points
	///
	/// vtkDynamic2DLabelMapper is a mapper that renders text at dataset
	/// points such that the labels do not overlap.
	/// Various items can be labeled including point ids, scalars,
	/// vectors, normals, texture coordinates, tensors, and field data components.
	/// This mapper assumes that the points are located on the x-y plane
	/// and that the camera remains perpendicular to that plane with a y-up
	/// axis (this can be constrained using vtkImageInteractor).
	/// On the first render, the mapper computes the visiblility of all labels
	/// at all scales, and queries this information on successive renders.
	/// This causes the first render to be much slower. The visibility algorithm
	/// is a greedy approach based on the point id, so the label for a point
	/// will be drawn unless the label for a point with lower id overlaps it.
	///
	/// @warning
	/// Use this filter in combination with vtkSelectVisiblePoints if you want
	/// to label only points that are visible. If you want to label cells rather
	/// than points, use the filter vtkCellCenters to generate points at the
	/// center of the cells. Also, you can use the class vtkIdFilter to
	/// generate ids as scalars or field data, which can then be labeled.
	///
	/// </remarks>
	/// <seealso>
	///
	/// vtkLabeledDataMapper
	///
	/// @par Thanks:
	/// This algorithm was developed in the paper
	/// Ken Been and Chee Yap. Dynamic Map Labeling. IEEE Transactions on
	/// Visualization and Computer Graphics, Vol. 12, No. 5, 2006. pp. 773-780.
	/// </seealso>
	// Token: 0x020000E4 RID: 228
	public class vtkDynamic2DLabelMapper : vtkLabeledDataMapper
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x06002F6E RID: 12142 RVA: 0x00045617 File Offset: 0x00043817
		static vtkDynamic2DLabelMapper()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkDynamic2DLabelMapper.MRClassNameKey, Type.GetType("Kitware.VTK.vtkDynamic2DLabelMapper"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x06002F6F RID: 12143 RVA: 0x0004563F File Offset: 0x0004383F
		public vtkDynamic2DLabelMapper(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x06002F70 RID: 12144
		[DllImport("Kitware.VTK.RenderingLabel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkDynamic2DLabelMapper_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Instantiate object with %%-#6.3g label format. By default, point ids
		/// are labeled.
		/// </summary>
		// Token: 0x06002F71 RID: 12145 RVA: 0x00045650 File Offset: 0x00043850
		public new static vtkDynamic2DLabelMapper New()
		{
			vtkDynamic2DLabelMapper result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkDynamic2DLabelMapper.vtkDynamic2DLabelMapper_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkDynamic2DLabelMapper)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		/// Instantiate object with %%-#6.3g label format. By default, point ids
		/// are labeled.
		/// </summary>
		// Token: 0x06002F72 RID: 12146 RVA: 0x000456A4 File Offset: 0x000438A4
		public vtkDynamic2DLabelMapper() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkDynamic2DLabelMapper.vtkDynamic2DLabelMapper_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x06002F73 RID: 12147 RVA: 0x000456E8 File Offset: 0x000438E8
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x06002F74 RID: 12148
		[DllImport("Kitware.VTK.RenderingLabel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern float vtkDynamic2DLabelMapper_GetLabelHeightPadding_01(HandleRef pThis);

		/// <summary>
		/// Set the label height padding as a percentage. The percentage
		/// is a percentage of your label height.
		/// Default is 50%.
		/// </summary>
		// Token: 0x06002F75 RID: 12149 RVA: 0x000456F4 File Offset: 0x000438F4
		public virtual float GetLabelHeightPadding()
		{
			return vtkDynamic2DLabelMapper.vtkDynamic2DLabelMapper_GetLabelHeightPadding_01(base.GetCppThis());
		}

		// Token: 0x06002F76 RID: 12150
		[DllImport("Kitware.VTK.RenderingLabel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern float vtkDynamic2DLabelMapper_GetLabelWidthPadding_02(HandleRef pThis);

		/// <summary>
		/// Set the label width padding as a percentage. The percentage
		/// is a percentage of your label ^height^ (yes, not a typo).
		/// Default is 50%.
		/// </summary>
		// Token: 0x06002F77 RID: 12151 RVA: 0x00045714 File Offset: 0x00043914
		public virtual float GetLabelWidthPadding()
		{
			return vtkDynamic2DLabelMapper.vtkDynamic2DLabelMapper_GetLabelWidthPadding_02(base.GetCppThis());
		}

		// Token: 0x06002F78 RID: 12152
		[DllImport("Kitware.VTK.RenderingLabel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkDynamic2DLabelMapper_GetNumberOfGenerationsFromBase_03(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		/// Instantiate object with %%-#6.3g label format. By default, point ids
		/// are labeled.
		/// </summary>
		// Token: 0x06002F79 RID: 12153 RVA: 0x00045734 File Offset: 0x00043934
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkDynamic2DLabelMapper.vtkDynamic2DLabelMapper_GetNumberOfGenerationsFromBase_03(base.GetCppThis(), type);
		}

		// Token: 0x06002F7A RID: 12154
		[DllImport("Kitware.VTK.RenderingLabel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkDynamic2DLabelMapper_GetNumberOfGenerationsFromBaseType_04([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		/// Instantiate object with %%-#6.3g label format. By default, point ids
		/// are labeled.
		/// </summary>
		// Token: 0x06002F7B RID: 12155 RVA: 0x00045754 File Offset: 0x00043954
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkDynamic2DLabelMapper.vtkDynamic2DLabelMapper_GetNumberOfGenerationsFromBaseType_04(type);
		}

		// Token: 0x06002F7C RID: 12156
		[DllImport("Kitware.VTK.RenderingLabel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkDynamic2DLabelMapper_GetReversePriority_05(HandleRef pThis);

		/// <summary>
		/// Whether to reverse the priority order (i.e. low values have high priority).
		/// Default is off.
		/// </summary>
		// Token: 0x06002F7D RID: 12157 RVA: 0x00045770 File Offset: 0x00043970
		public virtual bool GetReversePriority()
		{
			return vtkDynamic2DLabelMapper.vtkDynamic2DLabelMapper_GetReversePriority_05(base.GetCppThis()) != 0;
		}

		// Token: 0x06002F7E RID: 12158
		[DllImport("Kitware.VTK.RenderingLabel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkDynamic2DLabelMapper_IsA_06(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		/// Instantiate object with %%-#6.3g label format. By default, point ids
		/// are labeled.
		/// </summary>
		// Token: 0x06002F7F RID: 12159 RVA: 0x00045798 File Offset: 0x00043998
		public override int IsA(string type)
		{
			return vtkDynamic2DLabelMapper.vtkDynamic2DLabelMapper_IsA_06(base.GetCppThis(), type);
		}

		// Token: 0x06002F80 RID: 12160
		[DllImport("Kitware.VTK.RenderingLabel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkDynamic2DLabelMapper_IsTypeOf_07([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		/// Instantiate object with %%-#6.3g label format. By default, point ids
		/// are labeled.
		/// </summary>
		// Token: 0x06002F81 RID: 12161 RVA: 0x000457B8 File Offset: 0x000439B8
		public new static int IsTypeOf(string type)
		{
			return vtkDynamic2DLabelMapper.vtkDynamic2DLabelMapper_IsTypeOf_07(type);
		}

		// Token: 0x06002F82 RID: 12162
		[DllImport("Kitware.VTK.RenderingLabel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkDynamic2DLabelMapper_NewInstance_09(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Instantiate object with %%-#6.3g label format. By default, point ids
		/// are labeled.
		/// </summary>
		// Token: 0x06002F83 RID: 12163 RVA: 0x000457D4 File Offset: 0x000439D4
		public new vtkDynamic2DLabelMapper NewInstance()
		{
			vtkDynamic2DLabelMapper result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkDynamic2DLabelMapper.vtkDynamic2DLabelMapper_NewInstance_09(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkDynamic2DLabelMapper)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x06002F84 RID: 12164
		[DllImport("Kitware.VTK.RenderingLabel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkDynamic2DLabelMapper_RenderOpaqueGeometry_10(HandleRef pThis, HandleRef viewport, HandleRef actor);

		/// <summary>
		/// Draw non-overlapping labels to the screen.
		/// </summary>
		// Token: 0x06002F85 RID: 12165 RVA: 0x00045830 File Offset: 0x00043A30
		public override void RenderOpaqueGeometry(vtkViewport viewport, vtkActor2D actor)
		{
			vtkDynamic2DLabelMapper.vtkDynamic2DLabelMapper_RenderOpaqueGeometry_10(base.GetCppThis(), (viewport == null) ? default(HandleRef) : viewport.GetCppThis(), (actor == null) ? default(HandleRef) : actor.GetCppThis());
		}

		// Token: 0x06002F86 RID: 12166
		[DllImport("Kitware.VTK.RenderingLabel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkDynamic2DLabelMapper_RenderOverlay_11(HandleRef pThis, HandleRef viewport, HandleRef actor);

		/// <summary>
		/// Draw non-overlapping labels to the screen.
		/// </summary>
		// Token: 0x06002F87 RID: 12167 RVA: 0x00045874 File Offset: 0x00043A74
		public override void RenderOverlay(vtkViewport viewport, vtkActor2D actor)
		{
			vtkDynamic2DLabelMapper.vtkDynamic2DLabelMapper_RenderOverlay_11(base.GetCppThis(), (viewport == null) ? default(HandleRef) : viewport.GetCppThis(), (actor == null) ? default(HandleRef) : actor.GetCppThis());
		}

		// Token: 0x06002F88 RID: 12168
		[DllImport("Kitware.VTK.RenderingLabel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkDynamic2DLabelMapper_ReversePriorityOff_12(HandleRef pThis);

		/// <summary>
		/// Whether to reverse the priority order (i.e. low values have high priority).
		/// Default is off.
		/// </summary>
		// Token: 0x06002F89 RID: 12169 RVA: 0x000458B8 File Offset: 0x00043AB8
		public virtual void ReversePriorityOff()
		{
			vtkDynamic2DLabelMapper.vtkDynamic2DLabelMapper_ReversePriorityOff_12(base.GetCppThis());
		}

		// Token: 0x06002F8A RID: 12170
		[DllImport("Kitware.VTK.RenderingLabel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkDynamic2DLabelMapper_ReversePriorityOn_13(HandleRef pThis);

		/// <summary>
		/// Whether to reverse the priority order (i.e. low values have high priority).
		/// Default is off.
		/// </summary>
		// Token: 0x06002F8B RID: 12171 RVA: 0x000458C7 File Offset: 0x00043AC7
		public virtual void ReversePriorityOn()
		{
			vtkDynamic2DLabelMapper.vtkDynamic2DLabelMapper_ReversePriorityOn_13(base.GetCppThis());
		}

		// Token: 0x06002F8C RID: 12172
		[DllImport("Kitware.VTK.RenderingLabel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkDynamic2DLabelMapper_SafeDownCast_14(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Instantiate object with %%-#6.3g label format. By default, point ids
		/// are labeled.
		/// </summary>
		// Token: 0x06002F8D RID: 12173 RVA: 0x000458D8 File Offset: 0x00043AD8
		public new static vtkDynamic2DLabelMapper SafeDownCast(vtkObjectBase o)
		{
			vtkDynamic2DLabelMapper vtkDynamic2DLabelMapper = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkDynamic2DLabelMapper.vtkDynamic2DLabelMapper_SafeDownCast_14((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkDynamic2DLabelMapper = (vtkDynamic2DLabelMapper)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkDynamic2DLabelMapper.Register(null);
				}
			}
			return vtkDynamic2DLabelMapper;
		}

		// Token: 0x06002F8E RID: 12174
		[DllImport("Kitware.VTK.RenderingLabel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkDynamic2DLabelMapper_SetLabelHeightPadding_15(HandleRef pThis, float _arg);

		/// <summary>
		/// Set the label height padding as a percentage. The percentage
		/// is a percentage of your label height.
		/// Default is 50%.
		/// </summary>
		// Token: 0x06002F8F RID: 12175 RVA: 0x00045957 File Offset: 0x00043B57
		public virtual void SetLabelHeightPadding(float _arg)
		{
			vtkDynamic2DLabelMapper.vtkDynamic2DLabelMapper_SetLabelHeightPadding_15(base.GetCppThis(), _arg);
		}

		// Token: 0x06002F90 RID: 12176
		[DllImport("Kitware.VTK.RenderingLabel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkDynamic2DLabelMapper_SetLabelWidthPadding_16(HandleRef pThis, float _arg);

		/// <summary>
		/// Set the label width padding as a percentage. The percentage
		/// is a percentage of your label ^height^ (yes, not a typo).
		/// Default is 50%.
		/// </summary>
		// Token: 0x06002F91 RID: 12177 RVA: 0x00045967 File Offset: 0x00043B67
		public virtual void SetLabelWidthPadding(float _arg)
		{
			vtkDynamic2DLabelMapper.vtkDynamic2DLabelMapper_SetLabelWidthPadding_16(base.GetCppThis(), _arg);
		}

		// Token: 0x06002F92 RID: 12178
		[DllImport("Kitware.VTK.RenderingLabel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkDynamic2DLabelMapper_SetPriorityArrayName_17(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string name);

		/// <summary>
		/// Set the points array name to use to give priority to labels.
		/// Defaults to "priority".
		/// </summary>
		// Token: 0x06002F93 RID: 12179 RVA: 0x00045977 File Offset: 0x00043B77
		public void SetPriorityArrayName(string name)
		{
			vtkDynamic2DLabelMapper.vtkDynamic2DLabelMapper_SetPriorityArrayName_17(base.GetCppThis(), name);
		}

		// Token: 0x06002F94 RID: 12180
		[DllImport("Kitware.VTK.RenderingLabel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkDynamic2DLabelMapper_SetReversePriority_18(HandleRef pThis, byte _arg);

		/// <summary>
		/// Whether to reverse the priority order (i.e. low values have high priority).
		/// Default is off.
		/// </summary>
		// Token: 0x06002F95 RID: 12181 RVA: 0x00045987 File Offset: 0x00043B87
		public virtual void SetReversePriority(bool _arg)
		{
			vtkDynamic2DLabelMapper.vtkDynamic2DLabelMapper_SetReversePriority_18(base.GetCppThis(), _arg ? (byte)1 : (byte)0);
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x040005CD RID: 1485
		public new const string MRFullTypeName = "Kitware.VTK.vtkDynamic2DLabelMapper";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x040005CE RID: 1486
		public new static readonly string MRClassNameKey = "class vtkDynamic2DLabelMapper";
	}
}
