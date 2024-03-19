using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkImageActorPointPlacer
	/// </summary>
	/// <remarks>
	///    Converts 2D display positions to world positions such that they lie on an ImageActor
	///
	/// This PointPlacer is used to constrain the placement of points on the
	/// supplied image actor. Additionally, you may set bounds to restrict the
	/// placement of the points. The placement of points will then be constrained
	/// to lie not only on the ImageActor but also within the bounds specified.
	/// If no bounds are specified, they may lie anywhere on the supplied ImageActor.
	/// </remarks>
	// Token: 0x02000320 RID: 800
	public class vtkImageActorPointPlacer : vtkPointPlacer
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x06008F40 RID: 36672 RVA: 0x000CC249 File Offset: 0x000CA449
		static vtkImageActorPointPlacer()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkImageActorPointPlacer.MRClassNameKey, Type.GetType("Kitware.VTK.vtkImageActorPointPlacer"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x06008F41 RID: 36673 RVA: 0x000CC271 File Offset: 0x000CA471
		public vtkImageActorPointPlacer(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x06008F42 RID: 36674
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkImageActorPointPlacer_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Instantiate this class.
		/// </summary>
		// Token: 0x06008F43 RID: 36675 RVA: 0x000CC280 File Offset: 0x000CA480
		public new static vtkImageActorPointPlacer New()
		{
			vtkImageActorPointPlacer result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkImageActorPointPlacer.vtkImageActorPointPlacer_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkImageActorPointPlacer)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		/// Instantiate this class.
		/// </summary>
		// Token: 0x06008F44 RID: 36676 RVA: 0x000CC2D4 File Offset: 0x000CA4D4
		public vtkImageActorPointPlacer() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkImageActorPointPlacer.vtkImageActorPointPlacer_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x06008F45 RID: 36677 RVA: 0x000CC318 File Offset: 0x000CA518
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x06008F46 RID: 36678
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkImageActorPointPlacer_ComputeWorldPosition_01(HandleRef pThis, HandleRef ren, IntPtr displayPos, IntPtr worldPos, IntPtr worldOrient);

		/// <summary>
		/// Given and renderer and a display position in pixels,
		/// find a world position and orientation. In this class
		/// an internal vtkBoundedPlanePointPlacer is used to compute
		/// the world position and orientation. The internal placer
		/// is set to use the plane of the image actor and the bounds
		/// of the image actor as the constraints for placing points.
		/// </summary>
		// Token: 0x06008F47 RID: 36679 RVA: 0x000CC324 File Offset: 0x000CA524
		public override int ComputeWorldPosition(vtkRenderer ren, IntPtr displayPos, IntPtr worldPos, IntPtr worldOrient)
		{
			return vtkImageActorPointPlacer.vtkImageActorPointPlacer_ComputeWorldPosition_01(base.GetCppThis(), (ren == null) ? default(HandleRef) : ren.GetCppThis(), displayPos, worldPos, worldOrient);
		}

		// Token: 0x06008F48 RID: 36680
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkImageActorPointPlacer_ComputeWorldPosition_02(HandleRef pThis, HandleRef ren, IntPtr displayPos, IntPtr refWorldPos, IntPtr worldPos, IntPtr worldOrient);

		/// <summary>
		/// This method is identical to the one above since the
		/// reference position is ignored by the bounded plane
		/// point placer.
		/// </summary>
		// Token: 0x06008F49 RID: 36681 RVA: 0x000CC35C File Offset: 0x000CA55C
		public override int ComputeWorldPosition(vtkRenderer ren, IntPtr displayPos, IntPtr refWorldPos, IntPtr worldPos, IntPtr worldOrient)
		{
			return vtkImageActorPointPlacer.vtkImageActorPointPlacer_ComputeWorldPosition_02(base.GetCppThis(), (ren == null) ? default(HandleRef) : ren.GetCppThis(), displayPos, refWorldPos, worldPos, worldOrient);
		}

		// Token: 0x06008F4A RID: 36682
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkImageActorPointPlacer_GetBounds_03(HandleRef pThis);

		/// <summary>
		/// Optionally, you may set bounds to restrict the placement of the points.
		/// The placement of points will then be constrained to lie not only on
		/// the ImageActor but also within the bounds specified. If no bounds are
		/// specified, they may lie anywhere on the supplied ImageActor.
		/// </summary>
		// Token: 0x06008F4B RID: 36683 RVA: 0x000CC398 File Offset: 0x000CA598
		public virtual double[] GetBounds()
		{
			IntPtr intPtr = vtkImageActorPointPlacer.vtkImageActorPointPlacer_GetBounds_03(base.GetCppThis());
			double[] array = null;
			if (IntPtr.Zero != intPtr)
			{
				array = new double[6];
				Marshal.Copy(intPtr, array, 0, array.Length);
			}
			return array;
		}

		// Token: 0x06008F4C RID: 36684
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImageActorPointPlacer_GetBounds_04(HandleRef pThis, ref double _arg1, ref double _arg2, ref double _arg3, ref double _arg4, ref double _arg5, ref double _arg6);

		/// <summary>
		/// Optionally, you may set bounds to restrict the placement of the points.
		/// The placement of points will then be constrained to lie not only on
		/// the ImageActor but also within the bounds specified. If no bounds are
		/// specified, they may lie anywhere on the supplied ImageActor.
		/// </summary>
		// Token: 0x06008F4D RID: 36685 RVA: 0x000CC3E0 File Offset: 0x000CA5E0
		public virtual void GetBounds(ref double _arg1, ref double _arg2, ref double _arg3, ref double _arg4, ref double _arg5, ref double _arg6)
		{
			vtkImageActorPointPlacer.vtkImageActorPointPlacer_GetBounds_04(base.GetCppThis(), ref _arg1, ref _arg2, ref _arg3, ref _arg4, ref _arg5, ref _arg6);
		}

		// Token: 0x06008F4E RID: 36686
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImageActorPointPlacer_GetBounds_05(HandleRef pThis, IntPtr _arg);

		/// <summary>
		/// Optionally, you may set bounds to restrict the placement of the points.
		/// The placement of points will then be constrained to lie not only on
		/// the ImageActor but also within the bounds specified. If no bounds are
		/// specified, they may lie anywhere on the supplied ImageActor.
		/// </summary>
		// Token: 0x06008F4F RID: 36687 RVA: 0x000CC3F8 File Offset: 0x000CA5F8
		public virtual void GetBounds(IntPtr _arg)
		{
			vtkImageActorPointPlacer.vtkImageActorPointPlacer_GetBounds_05(base.GetCppThis(), _arg);
		}

		// Token: 0x06008F50 RID: 36688
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkImageActorPointPlacer_GetImageActor_06(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Set / get the reference vtkImageActor used to place the points.
		/// An image actor must be set for this placer to work. An internal
		/// bounded plane point placer is created and set to match the bounds
		/// of the displayed image.
		/// </summary>
		// Token: 0x06008F51 RID: 36689 RVA: 0x000CC408 File Offset: 0x000CA608
		public virtual vtkImageActor GetImageActor()
		{
			vtkImageActor vtkImageActor = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkImageActorPointPlacer.vtkImageActorPointPlacer_GetImageActor_06(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkImageActor = (vtkImageActor)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkImageActor.Register(null);
				}
			}
			return vtkImageActor;
		}

		// Token: 0x06008F52 RID: 36690
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkImageActorPointPlacer_GetNumberOfGenerationsFromBase_07(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		/// Standard methods for instances of this class.
		/// </summary>
		// Token: 0x06008F53 RID: 36691 RVA: 0x000CC478 File Offset: 0x000CA678
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkImageActorPointPlacer.vtkImageActorPointPlacer_GetNumberOfGenerationsFromBase_07(base.GetCppThis(), type);
		}

		// Token: 0x06008F54 RID: 36692
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkImageActorPointPlacer_GetNumberOfGenerationsFromBaseType_08([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		/// Standard methods for instances of this class.
		/// </summary>
		// Token: 0x06008F55 RID: 36693 RVA: 0x000CC498 File Offset: 0x000CA698
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkImageActorPointPlacer.vtkImageActorPointPlacer_GetNumberOfGenerationsFromBaseType_08(type);
		}

		// Token: 0x06008F56 RID: 36694
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkImageActorPointPlacer_IsA_09(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		/// Standard methods for instances of this class.
		/// </summary>
		// Token: 0x06008F57 RID: 36695 RVA: 0x000CC4B4 File Offset: 0x000CA6B4
		public override int IsA(string type)
		{
			return vtkImageActorPointPlacer.vtkImageActorPointPlacer_IsA_09(base.GetCppThis(), type);
		}

		// Token: 0x06008F58 RID: 36696
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkImageActorPointPlacer_IsTypeOf_10([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		/// Standard methods for instances of this class.
		/// </summary>
		// Token: 0x06008F59 RID: 36697 RVA: 0x000CC4D4 File Offset: 0x000CA6D4
		public new static int IsTypeOf(string type)
		{
			return vtkImageActorPointPlacer.vtkImageActorPointPlacer_IsTypeOf_10(type);
		}

		// Token: 0x06008F5A RID: 36698
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkImageActorPointPlacer_NewInstance_12(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Standard methods for instances of this class.
		/// </summary>
		// Token: 0x06008F5B RID: 36699 RVA: 0x000CC4F0 File Offset: 0x000CA6F0
		public new vtkImageActorPointPlacer NewInstance()
		{
			vtkImageActorPointPlacer result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkImageActorPointPlacer.vtkImageActorPointPlacer_NewInstance_12(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkImageActorPointPlacer)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x06008F5C RID: 36700
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkImageActorPointPlacer_SafeDownCast_13(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Standard methods for instances of this class.
		/// </summary>
		// Token: 0x06008F5D RID: 36701 RVA: 0x000CC54C File Offset: 0x000CA74C
		public new static vtkImageActorPointPlacer SafeDownCast(vtkObjectBase o)
		{
			vtkImageActorPointPlacer vtkImageActorPointPlacer = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkImageActorPointPlacer.vtkImageActorPointPlacer_SafeDownCast_13((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkImageActorPointPlacer = (vtkImageActorPointPlacer)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkImageActorPointPlacer.Register(null);
				}
			}
			return vtkImageActorPointPlacer;
		}

		// Token: 0x06008F5E RID: 36702
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImageActorPointPlacer_SetBounds_14(HandleRef pThis, double _arg1, double _arg2, double _arg3, double _arg4, double _arg5, double _arg6);

		/// <summary>
		/// Optionally, you may set bounds to restrict the placement of the points.
		/// The placement of points will then be constrained to lie not only on
		/// the ImageActor but also within the bounds specified. If no bounds are
		/// specified, they may lie anywhere on the supplied ImageActor.
		/// </summary>
		// Token: 0x06008F5F RID: 36703 RVA: 0x000CC5CB File Offset: 0x000CA7CB
		public virtual void SetBounds(double _arg1, double _arg2, double _arg3, double _arg4, double _arg5, double _arg6)
		{
			vtkImageActorPointPlacer.vtkImageActorPointPlacer_SetBounds_14(base.GetCppThis(), _arg1, _arg2, _arg3, _arg4, _arg5, _arg6);
		}

		// Token: 0x06008F60 RID: 36704
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImageActorPointPlacer_SetBounds_15(HandleRef pThis, IntPtr _arg);

		/// <summary>
		/// Optionally, you may set bounds to restrict the placement of the points.
		/// The placement of points will then be constrained to lie not only on
		/// the ImageActor but also within the bounds specified. If no bounds are
		/// specified, they may lie anywhere on the supplied ImageActor.
		/// </summary>
		// Token: 0x06008F61 RID: 36705 RVA: 0x000CC5E3 File Offset: 0x000CA7E3
		public virtual void SetBounds(IntPtr _arg)
		{
			vtkImageActorPointPlacer.vtkImageActorPointPlacer_SetBounds_15(base.GetCppThis(), _arg);
		}

		// Token: 0x06008F62 RID: 36706
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImageActorPointPlacer_SetImageActor_16(HandleRef pThis, HandleRef arg0);

		/// <summary>
		/// Set / get the reference vtkImageActor used to place the points.
		/// An image actor must be set for this placer to work. An internal
		/// bounded plane point placer is created and set to match the bounds
		/// of the displayed image.
		/// </summary>
		// Token: 0x06008F63 RID: 36707 RVA: 0x000CC5F4 File Offset: 0x000CA7F4
		public void SetImageActor(vtkImageActor arg0)
		{
			vtkImageActorPointPlacer.vtkImageActorPointPlacer_SetImageActor_16(base.GetCppThis(), (arg0 == null) ? default(HandleRef) : arg0.GetCppThis());
		}

		// Token: 0x06008F64 RID: 36708
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImageActorPointPlacer_SetWorldTolerance_17(HandleRef pThis, double tol);

		/// <summary>
		/// Set the world tolerance. This propagates it to the internal
		/// BoundedPlanePointPlacer.
		/// </summary>
		// Token: 0x06008F65 RID: 36709 RVA: 0x000CC623 File Offset: 0x000CA823
		public override void SetWorldTolerance(double tol)
		{
			vtkImageActorPointPlacer.vtkImageActorPointPlacer_SetWorldTolerance_17(base.GetCppThis(), tol);
		}

		// Token: 0x06008F66 RID: 36710
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkImageActorPointPlacer_UpdateInternalState_18(HandleRef pThis);

		/// <summary>
		/// A method for configuring the internal placer according
		/// to the constraints of the image actor.
		/// Called by the representation to give the placer a chance
		/// to update itself, which may cause the MTime to change,
		/// which would then cause the representation to update
		/// all of its points
		/// </summary>
		// Token: 0x06008F67 RID: 36711 RVA: 0x000CC634 File Offset: 0x000CA834
		public override int UpdateInternalState()
		{
			return vtkImageActorPointPlacer.vtkImageActorPointPlacer_UpdateInternalState_18(base.GetCppThis());
		}

		// Token: 0x06008F68 RID: 36712
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkImageActorPointPlacer_UpdateWorldPosition_19(HandleRef pThis, HandleRef ren, IntPtr worldPos, IntPtr worldOrient);

		/// <summary>
		/// Update the world position and orientation according the
		/// the current constraints of the placer. Will be called
		/// by the representation when it notices that this placer
		/// has been modified.
		/// </summary>
		// Token: 0x06008F69 RID: 36713 RVA: 0x000CC654 File Offset: 0x000CA854
		public override int UpdateWorldPosition(vtkRenderer ren, IntPtr worldPos, IntPtr worldOrient)
		{
			return vtkImageActorPointPlacer.vtkImageActorPointPlacer_UpdateWorldPosition_19(base.GetCppThis(), (ren == null) ? default(HandleRef) : ren.GetCppThis(), worldPos, worldOrient);
		}

		// Token: 0x06008F6A RID: 36714
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkImageActorPointPlacer_ValidateWorldPosition_20(HandleRef pThis, IntPtr worldPos);

		/// <summary>
		/// This method validates a world position by checking to see
		/// if the world position is valid according to the constraints
		/// of the internal placer (essentially - is this world position
		/// on the image?)
		/// </summary>
		// Token: 0x06008F6B RID: 36715 RVA: 0x000CC68C File Offset: 0x000CA88C
		public override int ValidateWorldPosition(IntPtr worldPos)
		{
			return vtkImageActorPointPlacer.vtkImageActorPointPlacer_ValidateWorldPosition_20(base.GetCppThis(), worldPos);
		}

		// Token: 0x06008F6C RID: 36716
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkImageActorPointPlacer_ValidateWorldPosition_21(HandleRef pThis, IntPtr worldPos, IntPtr worldOrient);

		/// <summary>
		/// This method is identical to the one above since the bounded
		/// plane point placer ignores orientation
		/// </summary>
		// Token: 0x06008F6D RID: 36717 RVA: 0x000CC6AC File Offset: 0x000CA8AC
		public override int ValidateWorldPosition(IntPtr worldPos, IntPtr worldOrient)
		{
			return vtkImageActorPointPlacer.vtkImageActorPointPlacer_ValidateWorldPosition_21(base.GetCppThis(), worldPos, worldOrient);
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04000BFC RID: 3068
		public new const string MRFullTypeName = "Kitware.VTK.vtkImageActorPointPlacer";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04000BFD RID: 3069
		public new static readonly string MRClassNameKey = "class vtkImageActorPointPlacer";
	}
}
