using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkContourLineInterpolator
	/// </summary>
	/// <remarks>
	///    Defines API for interpolating/modifying nodes from a vtkContourRepresentation
	///
	/// vtkContourLineInterpolator is an abstract base class for interpolators
	/// that are used by the vtkContourRepresentation class to interpolate
	/// and/or modify nodes in a contour. Subclasses must override the virtual
	/// method \c InterpolateLine. This is used by the contour representation
	/// to give the interpolator a chance to define an interpolation scheme
	/// between nodes. See vtkBezierContourLineInterpolator for a concrete
	/// implementation. Subclasses may also override \c UpdateNode. This provides
	/// a way for the representation to give the interpolator a chance to modify
	/// the nodes, as the user constructs the contours. For instance, a sticky
	/// contour widget may be implemented that moves nodes to nearby regions of
	/// high gradient, to be used in contour-guided segmentation.
	/// </remarks>
	// Token: 0x020002C5 RID: 709
	public abstract class vtkContourLineInterpolator : vtkObject
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x06007FCF RID: 32719 RVA: 0x000B76FC File Offset: 0x000B58FC
		static vtkContourLineInterpolator()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkContourLineInterpolator.MRClassNameKey, Type.GetType("Kitware.VTK.vtkContourLineInterpolator"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x06007FD0 RID: 32720 RVA: 0x000B7724 File Offset: 0x000B5924
		public vtkContourLineInterpolator(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x06007FD1 RID: 32721 RVA: 0x000B7732 File Offset: 0x000B5932
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x06007FD2 RID: 32722
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkContourLineInterpolator_GetNumberOfGenerationsFromBase_01(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		/// Standard methods for instances of this class.
		/// </summary>
		// Token: 0x06007FD3 RID: 32723 RVA: 0x000B7740 File Offset: 0x000B5940
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkContourLineInterpolator.vtkContourLineInterpolator_GetNumberOfGenerationsFromBase_01(base.GetCppThis(), type);
		}

		// Token: 0x06007FD4 RID: 32724
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkContourLineInterpolator_GetNumberOfGenerationsFromBaseType_02([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		/// Standard methods for instances of this class.
		/// </summary>
		// Token: 0x06007FD5 RID: 32725 RVA: 0x000B7760 File Offset: 0x000B5960
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkContourLineInterpolator.vtkContourLineInterpolator_GetNumberOfGenerationsFromBaseType_02(type);
		}

		// Token: 0x06007FD6 RID: 32726
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkContourLineInterpolator_GetSpan_03(HandleRef pThis, int nodeIndex, HandleRef nodeIndices, HandleRef rep);

		/// <summary>
		/// Span of the interpolator. ie. the number of control points its supposed
		/// to interpolate given a node.
		///
		/// The first argument is the current nodeIndex.
		/// ie, you'd be trying to interpolate between nodes "nodeIndex" and
		/// "nodeIndex-1", unless you're closing the contour in which case, you're
		/// trying to interpolate "nodeIndex" and "Node=0".
		///
		/// The node span is returned in a vtkIntArray. The default node span is 1
		/// (ie. nodeIndices is a 2 tuple (nodeIndex, nodeIndex-1)). However, it
		/// need not always be 1. For instance, cubic spline interpolators, which
		/// have a span of 3 control points, it can be larger. See
		/// vtkBezierContourLineInterpolator for instance.
		/// </summary>
		// Token: 0x06007FD7 RID: 32727 RVA: 0x000B777C File Offset: 0x000B597C
		public virtual void GetSpan(int nodeIndex, vtkIntArray nodeIndices, vtkContourRepresentation rep)
		{
			vtkContourLineInterpolator.vtkContourLineInterpolator_GetSpan_03(base.GetCppThis(), nodeIndex, (nodeIndices == null) ? default(HandleRef) : nodeIndices.GetCppThis(), (rep == null) ? default(HandleRef) : rep.GetCppThis());
		}

		// Token: 0x06007FD8 RID: 32728
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkContourLineInterpolator_InterpolateLine_04(HandleRef pThis, HandleRef ren, HandleRef rep, int idx1, int idx2);

		/// <summary>
		/// Subclasses that wish to interpolate a line segment must implement this.
		/// For instance vtkBezierContourLineInterpolator adds nodes between idx1
		/// and idx2, that allow the contour to adhere to a bezier curve.
		/// </summary>
		// Token: 0x06007FD9 RID: 32729 RVA: 0x000B77C4 File Offset: 0x000B59C4
		public virtual int InterpolateLine(vtkRenderer ren, vtkContourRepresentation rep, int idx1, int idx2)
		{
			return vtkContourLineInterpolator.vtkContourLineInterpolator_InterpolateLine_04(base.GetCppThis(), (ren == null) ? default(HandleRef) : ren.GetCppThis(), (rep == null) ? default(HandleRef) : rep.GetCppThis(), idx1, idx2);
		}

		// Token: 0x06007FDA RID: 32730
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkContourLineInterpolator_IsA_05(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		/// Standard methods for instances of this class.
		/// </summary>
		// Token: 0x06007FDB RID: 32731 RVA: 0x000B7810 File Offset: 0x000B5A10
		public override int IsA(string type)
		{
			return vtkContourLineInterpolator.vtkContourLineInterpolator_IsA_05(base.GetCppThis(), type);
		}

		// Token: 0x06007FDC RID: 32732
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkContourLineInterpolator_IsTypeOf_06([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		/// Standard methods for instances of this class.
		/// </summary>
		// Token: 0x06007FDD RID: 32733 RVA: 0x000B7830 File Offset: 0x000B5A30
		public new static int IsTypeOf(string type)
		{
			return vtkContourLineInterpolator.vtkContourLineInterpolator_IsTypeOf_06(type);
		}

		// Token: 0x06007FDE RID: 32734
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkContourLineInterpolator_NewInstance_07(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Standard methods for instances of this class.
		/// </summary>
		// Token: 0x06007FDF RID: 32735 RVA: 0x000B784C File Offset: 0x000B5A4C
		public new vtkContourLineInterpolator NewInstance()
		{
			vtkContourLineInterpolator result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkContourLineInterpolator.vtkContourLineInterpolator_NewInstance_07(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkContourLineInterpolator)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x06007FE0 RID: 32736
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkContourLineInterpolator_SafeDownCast_08(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Standard methods for instances of this class.
		/// </summary>
		// Token: 0x06007FE1 RID: 32737 RVA: 0x000B78A8 File Offset: 0x000B5AA8
		public new static vtkContourLineInterpolator SafeDownCast(vtkObjectBase o)
		{
			vtkContourLineInterpolator vtkContourLineInterpolator = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkContourLineInterpolator.vtkContourLineInterpolator_SafeDownCast_08((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkContourLineInterpolator = (vtkContourLineInterpolator)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkContourLineInterpolator.Register(null);
				}
			}
			return vtkContourLineInterpolator;
		}

		// Token: 0x06007FE2 RID: 32738
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkContourLineInterpolator_UpdateNode_09(HandleRef pThis, HandleRef arg0, HandleRef arg1, IntPtr arg2, int arg3);

		/// <summary>
		/// The interpolator is given a chance to update the node. For instance, the
		/// vtkImageContourLineInterpolator updates the idx'th node in the contour,
		/// so it automatically sticks to edges in the vicinity as the user
		/// constructs the contour.
		/// Returns 0 if the node (world position) is unchanged.
		/// </summary>
		// Token: 0x06007FE3 RID: 32739 RVA: 0x000B7928 File Offset: 0x000B5B28
		public virtual int UpdateNode(vtkRenderer arg0, vtkContourRepresentation arg1, IntPtr arg2, int arg3)
		{
			return vtkContourLineInterpolator.vtkContourLineInterpolator_UpdateNode_09(base.GetCppThis(), (arg0 == null) ? default(HandleRef) : arg0.GetCppThis(), (arg1 == null) ? default(HandleRef) : arg1.GetCppThis(), arg2, arg3);
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04000ACC RID: 2764
		public new const string MRFullTypeName = "Kitware.VTK.vtkContourLineInterpolator";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04000ACD RID: 2765
		public new static readonly string MRClassNameKey = "class vtkContourLineInterpolator";
	}
}
