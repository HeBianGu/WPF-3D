using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkBezierContourLineInterpolator
	/// </summary>
	/// <remarks>
	///    Interpolates supplied nodes with bezier line segments
	///
	/// The line interpolator interpolates supplied nodes (see InterpolateLine)
	/// with Bezier line segments. The fitness of the curve may be controlled using
	/// SetMaximumCurveError and SetMaximumNumberOfLineSegments.
	///
	/// </remarks>
	/// <seealso>
	///
	/// vtkContourLineInterpolator
	/// </seealso>
	// Token: 0x020002C6 RID: 710
	public class vtkBezierContourLineInterpolator : vtkContourLineInterpolator
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x06007FE4 RID: 32740 RVA: 0x000B7974 File Offset: 0x000B5B74
		static vtkBezierContourLineInterpolator()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkBezierContourLineInterpolator.MRClassNameKey, Type.GetType("Kitware.VTK.vtkBezierContourLineInterpolator"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x06007FE5 RID: 32741 RVA: 0x000B799C File Offset: 0x000B5B9C
		public vtkBezierContourLineInterpolator(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x06007FE6 RID: 32742
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkBezierContourLineInterpolator_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Instantiate this class.
		/// </summary>
		// Token: 0x06007FE7 RID: 32743 RVA: 0x000B79AC File Offset: 0x000B5BAC
		public new static vtkBezierContourLineInterpolator New()
		{
			vtkBezierContourLineInterpolator result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkBezierContourLineInterpolator.vtkBezierContourLineInterpolator_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkBezierContourLineInterpolator)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		/// Instantiate this class.
		/// </summary>
		// Token: 0x06007FE8 RID: 32744 RVA: 0x000B7A00 File Offset: 0x000B5C00
		public vtkBezierContourLineInterpolator() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkBezierContourLineInterpolator.vtkBezierContourLineInterpolator_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x06007FE9 RID: 32745 RVA: 0x000B7A44 File Offset: 0x000B5C44
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x06007FEA RID: 32746
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkBezierContourLineInterpolator_GetMaximumCurveError_01(HandleRef pThis);

		/// <summary>
		/// The difference between a line segment connecting two points and the curve
		/// connecting the same points. In the limit of the length of the curve
		/// dx -&gt; 0, the two values will be the same. The smaller this number, the
		/// finer the bezier curve will be interpolated. Default is 0.005
		/// </summary>
		// Token: 0x06007FEB RID: 32747 RVA: 0x000B7A50 File Offset: 0x000B5C50
		public virtual double GetMaximumCurveError()
		{
			return vtkBezierContourLineInterpolator.vtkBezierContourLineInterpolator_GetMaximumCurveError_01(base.GetCppThis());
		}

		// Token: 0x06007FEC RID: 32748
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkBezierContourLineInterpolator_GetMaximumCurveErrorMaxValue_02(HandleRef pThis);

		/// <summary>
		/// The difference between a line segment connecting two points and the curve
		/// connecting the same points. In the limit of the length of the curve
		/// dx -&gt; 0, the two values will be the same. The smaller this number, the
		/// finer the bezier curve will be interpolated. Default is 0.005
		/// </summary>
		// Token: 0x06007FED RID: 32749 RVA: 0x000B7A70 File Offset: 0x000B5C70
		public virtual double GetMaximumCurveErrorMaxValue()
		{
			return vtkBezierContourLineInterpolator.vtkBezierContourLineInterpolator_GetMaximumCurveErrorMaxValue_02(base.GetCppThis());
		}

		// Token: 0x06007FEE RID: 32750
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkBezierContourLineInterpolator_GetMaximumCurveErrorMinValue_03(HandleRef pThis);

		/// <summary>
		/// The difference between a line segment connecting two points and the curve
		/// connecting the same points. In the limit of the length of the curve
		/// dx -&gt; 0, the two values will be the same. The smaller this number, the
		/// finer the bezier curve will be interpolated. Default is 0.005
		/// </summary>
		// Token: 0x06007FEF RID: 32751 RVA: 0x000B7A90 File Offset: 0x000B5C90
		public virtual double GetMaximumCurveErrorMinValue()
		{
			return vtkBezierContourLineInterpolator.vtkBezierContourLineInterpolator_GetMaximumCurveErrorMinValue_03(base.GetCppThis());
		}

		// Token: 0x06007FF0 RID: 32752
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkBezierContourLineInterpolator_GetMaximumCurveLineSegments_04(HandleRef pThis);

		/// <summary>
		/// Maximum number of bezier line segments between two nodes. Larger values
		/// create a finer interpolation. Default is 100.
		/// </summary>
		// Token: 0x06007FF1 RID: 32753 RVA: 0x000B7AB0 File Offset: 0x000B5CB0
		public virtual int GetMaximumCurveLineSegments()
		{
			return vtkBezierContourLineInterpolator.vtkBezierContourLineInterpolator_GetMaximumCurveLineSegments_04(base.GetCppThis());
		}

		// Token: 0x06007FF2 RID: 32754
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkBezierContourLineInterpolator_GetMaximumCurveLineSegmentsMaxValue_05(HandleRef pThis);

		/// <summary>
		/// Maximum number of bezier line segments between two nodes. Larger values
		/// create a finer interpolation. Default is 100.
		/// </summary>
		// Token: 0x06007FF3 RID: 32755 RVA: 0x000B7AD0 File Offset: 0x000B5CD0
		public virtual int GetMaximumCurveLineSegmentsMaxValue()
		{
			return vtkBezierContourLineInterpolator.vtkBezierContourLineInterpolator_GetMaximumCurveLineSegmentsMaxValue_05(base.GetCppThis());
		}

		// Token: 0x06007FF4 RID: 32756
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkBezierContourLineInterpolator_GetMaximumCurveLineSegmentsMinValue_06(HandleRef pThis);

		/// <summary>
		/// Maximum number of bezier line segments between two nodes. Larger values
		/// create a finer interpolation. Default is 100.
		/// </summary>
		// Token: 0x06007FF5 RID: 32757 RVA: 0x000B7AF0 File Offset: 0x000B5CF0
		public virtual int GetMaximumCurveLineSegmentsMinValue()
		{
			return vtkBezierContourLineInterpolator.vtkBezierContourLineInterpolator_GetMaximumCurveLineSegmentsMinValue_06(base.GetCppThis());
		}

		// Token: 0x06007FF6 RID: 32758
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkBezierContourLineInterpolator_GetNumberOfGenerationsFromBase_07(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		/// Standard methods for instances of this class.
		/// </summary>
		// Token: 0x06007FF7 RID: 32759 RVA: 0x000B7B10 File Offset: 0x000B5D10
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkBezierContourLineInterpolator.vtkBezierContourLineInterpolator_GetNumberOfGenerationsFromBase_07(base.GetCppThis(), type);
		}

		// Token: 0x06007FF8 RID: 32760
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkBezierContourLineInterpolator_GetNumberOfGenerationsFromBaseType_08([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		/// Standard methods for instances of this class.
		/// </summary>
		// Token: 0x06007FF9 RID: 32761 RVA: 0x000B7B30 File Offset: 0x000B5D30
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkBezierContourLineInterpolator.vtkBezierContourLineInterpolator_GetNumberOfGenerationsFromBaseType_08(type);
		}

		// Token: 0x06007FFA RID: 32762
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkBezierContourLineInterpolator_GetSpan_09(HandleRef pThis, int nodeIndex, HandleRef nodeIndices, HandleRef rep);

		/// <summary>
		/// Span of the interpolator, i.e. the number of control points it's supposed
		/// to interpolate given a node.
		///
		/// The first argument is the current nodeIndex.
		/// i.e., you'd be trying to interpolate between nodes "nodeIndex" and
		/// "nodeIndex-1", unless you're closing the contour, in which case you're
		/// trying to interpolate "nodeIndex" and "Node=0". The node span is
		/// returned in a vtkIntArray.
		///
		/// The node span is returned in a vtkIntArray. The node span returned by
		/// this interpolator will be a 2-tuple with a span of 4.
		/// </summary>
		// Token: 0x06007FFB RID: 32763 RVA: 0x000B7B4C File Offset: 0x000B5D4C
		public override void GetSpan(int nodeIndex, vtkIntArray nodeIndices, vtkContourRepresentation rep)
		{
			vtkBezierContourLineInterpolator.vtkBezierContourLineInterpolator_GetSpan_09(base.GetCppThis(), nodeIndex, (nodeIndices == null) ? default(HandleRef) : nodeIndices.GetCppThis(), (rep == null) ? default(HandleRef) : rep.GetCppThis());
		}

		// Token: 0x06007FFC RID: 32764
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkBezierContourLineInterpolator_InterpolateLine_10(HandleRef pThis, HandleRef ren, HandleRef rep, int idx1, int idx2);

		/// <summary>
		/// Standard methods for instances of this class.
		/// </summary>
		// Token: 0x06007FFD RID: 32765 RVA: 0x000B7B94 File Offset: 0x000B5D94
		public override int InterpolateLine(vtkRenderer ren, vtkContourRepresentation rep, int idx1, int idx2)
		{
			return vtkBezierContourLineInterpolator.vtkBezierContourLineInterpolator_InterpolateLine_10(base.GetCppThis(), (ren == null) ? default(HandleRef) : ren.GetCppThis(), (rep == null) ? default(HandleRef) : rep.GetCppThis(), idx1, idx2);
		}

		// Token: 0x06007FFE RID: 32766
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkBezierContourLineInterpolator_IsA_11(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		/// Standard methods for instances of this class.
		/// </summary>
		// Token: 0x06007FFF RID: 32767 RVA: 0x000B7BE0 File Offset: 0x000B5DE0
		public override int IsA(string type)
		{
			return vtkBezierContourLineInterpolator.vtkBezierContourLineInterpolator_IsA_11(base.GetCppThis(), type);
		}

		// Token: 0x06008000 RID: 32768
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkBezierContourLineInterpolator_IsTypeOf_12([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		/// Standard methods for instances of this class.
		/// </summary>
		// Token: 0x06008001 RID: 32769 RVA: 0x000B7C00 File Offset: 0x000B5E00
		public new static int IsTypeOf(string type)
		{
			return vtkBezierContourLineInterpolator.vtkBezierContourLineInterpolator_IsTypeOf_12(type);
		}

		// Token: 0x06008002 RID: 32770
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkBezierContourLineInterpolator_NewInstance_14(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Standard methods for instances of this class.
		/// </summary>
		// Token: 0x06008003 RID: 32771 RVA: 0x000B7C1C File Offset: 0x000B5E1C
		public new vtkBezierContourLineInterpolator NewInstance()
		{
			vtkBezierContourLineInterpolator result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkBezierContourLineInterpolator.vtkBezierContourLineInterpolator_NewInstance_14(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkBezierContourLineInterpolator)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x06008004 RID: 32772
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkBezierContourLineInterpolator_SafeDownCast_15(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Standard methods for instances of this class.
		/// </summary>
		// Token: 0x06008005 RID: 32773 RVA: 0x000B7C78 File Offset: 0x000B5E78
		public new static vtkBezierContourLineInterpolator SafeDownCast(vtkObjectBase o)
		{
			vtkBezierContourLineInterpolator vtkBezierContourLineInterpolator = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkBezierContourLineInterpolator.vtkBezierContourLineInterpolator_SafeDownCast_15((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkBezierContourLineInterpolator = (vtkBezierContourLineInterpolator)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkBezierContourLineInterpolator.Register(null);
				}
			}
			return vtkBezierContourLineInterpolator;
		}

		// Token: 0x06008006 RID: 32774
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkBezierContourLineInterpolator_SetMaximumCurveError_16(HandleRef pThis, double _arg);

		/// <summary>
		/// The difference between a line segment connecting two points and the curve
		/// connecting the same points. In the limit of the length of the curve
		/// dx -&gt; 0, the two values will be the same. The smaller this number, the
		/// finer the bezier curve will be interpolated. Default is 0.005
		/// </summary>
		// Token: 0x06008007 RID: 32775 RVA: 0x000B7CF7 File Offset: 0x000B5EF7
		public virtual void SetMaximumCurveError(double _arg)
		{
			vtkBezierContourLineInterpolator.vtkBezierContourLineInterpolator_SetMaximumCurveError_16(base.GetCppThis(), _arg);
		}

		// Token: 0x06008008 RID: 32776
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkBezierContourLineInterpolator_SetMaximumCurveLineSegments_17(HandleRef pThis, int _arg);

		/// <summary>
		/// Maximum number of bezier line segments between two nodes. Larger values
		/// create a finer interpolation. Default is 100.
		/// </summary>
		// Token: 0x06008009 RID: 32777 RVA: 0x000B7D07 File Offset: 0x000B5F07
		public virtual void SetMaximumCurveLineSegments(int _arg)
		{
			vtkBezierContourLineInterpolator.vtkBezierContourLineInterpolator_SetMaximumCurveLineSegments_17(base.GetCppThis(), _arg);
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04000ACE RID: 2766
		public new const string MRFullTypeName = "Kitware.VTK.vtkBezierContourLineInterpolator";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04000ACF RID: 2767
		public new static readonly string MRClassNameKey = "class vtkBezierContourLineInterpolator";
	}
}
