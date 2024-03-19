using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkTensorProbeRepresentation
	/// </summary>
	/// <remarks>
	///    Abstract class that serves as a representation for vtkTensorProbeWidget
	///
	/// The class serves as an abstract geometrical representation for the
	/// vtkTensorProbeWidget. It is left to the concrete implementation to render
	/// the tensors as it desires. For instance,
	/// vtkEllipsoidTensorProbeRepresentation renders the tensors as ellipsoids.
	///
	/// </remarks>
	/// <seealso>
	///
	/// vtkTensorProbeWidget
	/// </seealso>
	// Token: 0x02000312 RID: 786
	public abstract class vtkTensorProbeRepresentation : vtkWidgetRepresentation
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x06008D5A RID: 36186 RVA: 0x000C9851 File Offset: 0x000C7A51
		static vtkTensorProbeRepresentation()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkTensorProbeRepresentation.MRClassNameKey, Type.GetType("Kitware.VTK.vtkTensorProbeRepresentation"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x06008D5B RID: 36187 RVA: 0x000C9879 File Offset: 0x000C7A79
		public vtkTensorProbeRepresentation(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x06008D5C RID: 36188 RVA: 0x000C9887 File Offset: 0x000C7A87
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x06008D5D RID: 36189
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkTensorProbeRepresentation_BuildRepresentation_01(HandleRef pThis);

		/// <summary>
		/// See vtkWidgetRepresentation for details.
		/// </summary>
		// Token: 0x06008D5E RID: 36190 RVA: 0x000C9892 File Offset: 0x000C7A92
		public override void BuildRepresentation()
		{
			vtkTensorProbeRepresentation.vtkTensorProbeRepresentation_BuildRepresentation_01(base.GetCppThis());
		}

		// Token: 0x06008D5F RID: 36191
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkTensorProbeRepresentation_GetActors_02(HandleRef pThis, HandleRef arg0);

		/// <summary>
		/// See vtkProp for details.
		/// </summary>
		// Token: 0x06008D60 RID: 36192 RVA: 0x000C98A4 File Offset: 0x000C7AA4
		public override void GetActors(vtkPropCollection arg0)
		{
			vtkTensorProbeRepresentation.vtkTensorProbeRepresentation_GetActors_02(base.GetCppThis(), (arg0 == null) ? default(HandleRef) : arg0.GetCppThis());
		}

		// Token: 0x06008D61 RID: 36193
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkTensorProbeRepresentation_GetNumberOfGenerationsFromBase_03(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		/// Standard methods for instances of this class.
		/// </summary>
		// Token: 0x06008D62 RID: 36194 RVA: 0x000C98D4 File Offset: 0x000C7AD4
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkTensorProbeRepresentation.vtkTensorProbeRepresentation_GetNumberOfGenerationsFromBase_03(base.GetCppThis(), type);
		}

		// Token: 0x06008D63 RID: 36195
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkTensorProbeRepresentation_GetNumberOfGenerationsFromBaseType_04([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		/// Standard methods for instances of this class.
		/// </summary>
		// Token: 0x06008D64 RID: 36196 RVA: 0x000C98F4 File Offset: 0x000C7AF4
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkTensorProbeRepresentation.vtkTensorProbeRepresentation_GetNumberOfGenerationsFromBaseType_04(type);
		}

		// Token: 0x06008D65 RID: 36197
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkTensorProbeRepresentation_GetProbeCellId_05(HandleRef pThis);

		/// <summary>
		/// Set the position of the Tensor probe.
		/// </summary>
		// Token: 0x06008D66 RID: 36198 RVA: 0x000C9910 File Offset: 0x000C7B10
		public virtual long GetProbeCellId()
		{
			return vtkTensorProbeRepresentation.vtkTensorProbeRepresentation_GetProbeCellId_05(base.GetCppThis());
		}

		// Token: 0x06008D67 RID: 36199
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkTensorProbeRepresentation_GetProbePosition_06(HandleRef pThis);

		/// <summary>
		/// Set the position of the Tensor probe.
		/// </summary>
		// Token: 0x06008D68 RID: 36200 RVA: 0x000C9930 File Offset: 0x000C7B30
		public virtual double[] GetProbePosition()
		{
			IntPtr intPtr = vtkTensorProbeRepresentation.vtkTensorProbeRepresentation_GetProbePosition_06(base.GetCppThis());
			double[] array = null;
			if (IntPtr.Zero != intPtr)
			{
				array = new double[3];
				Marshal.Copy(intPtr, array, 0, array.Length);
			}
			return array;
		}

		// Token: 0x06008D69 RID: 36201
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkTensorProbeRepresentation_GetProbePosition_07(HandleRef pThis, ref double _arg1, ref double _arg2, ref double _arg3);

		/// <summary>
		/// Set the position of the Tensor probe.
		/// </summary>
		// Token: 0x06008D6A RID: 36202 RVA: 0x000C9978 File Offset: 0x000C7B78
		public virtual void GetProbePosition(ref double _arg1, ref double _arg2, ref double _arg3)
		{
			vtkTensorProbeRepresentation.vtkTensorProbeRepresentation_GetProbePosition_07(base.GetCppThis(), ref _arg1, ref _arg2, ref _arg3);
		}

		// Token: 0x06008D6B RID: 36203
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkTensorProbeRepresentation_GetProbePosition_08(HandleRef pThis, IntPtr _arg);

		/// <summary>
		/// Set the position of the Tensor probe.
		/// </summary>
		// Token: 0x06008D6C RID: 36204 RVA: 0x000C998A File Offset: 0x000C7B8A
		public virtual void GetProbePosition(IntPtr _arg)
		{
			vtkTensorProbeRepresentation.vtkTensorProbeRepresentation_GetProbePosition_08(base.GetCppThis(), _arg);
		}

		// Token: 0x06008D6D RID: 36205
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkTensorProbeRepresentation_Initialize_09(HandleRef pThis);

		/// <summary>
		/// Set the probe position to a reasonable location on the trajectory.
		/// </summary>
		// Token: 0x06008D6E RID: 36206 RVA: 0x000C999A File Offset: 0x000C7B9A
		public void Initialize()
		{
			vtkTensorProbeRepresentation.vtkTensorProbeRepresentation_Initialize_09(base.GetCppThis());
		}

		// Token: 0x06008D6F RID: 36207
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkTensorProbeRepresentation_IsA_10(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		/// Standard methods for instances of this class.
		/// </summary>
		// Token: 0x06008D70 RID: 36208 RVA: 0x000C99AC File Offset: 0x000C7BAC
		public override int IsA(string type)
		{
			return vtkTensorProbeRepresentation.vtkTensorProbeRepresentation_IsA_10(base.GetCppThis(), type);
		}

		// Token: 0x06008D71 RID: 36209
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkTensorProbeRepresentation_IsTypeOf_11([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		/// Standard methods for instances of this class.
		/// </summary>
		// Token: 0x06008D72 RID: 36210 RVA: 0x000C99CC File Offset: 0x000C7BCC
		public new static int IsTypeOf(string type)
		{
			return vtkTensorProbeRepresentation.vtkTensorProbeRepresentation_IsTypeOf_11(type);
		}

		// Token: 0x06008D73 RID: 36211
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkTensorProbeRepresentation_Move_12(HandleRef pThis, IntPtr motionVector);

		/// <summary>
		/// INTERNAL - Do not use
		/// This method is invoked by the widget during user interaction.
		/// Move probe based on the position and the motion vector.
		/// </summary>
		// Token: 0x06008D74 RID: 36212 RVA: 0x000C99E8 File Offset: 0x000C7BE8
		public virtual int Move(IntPtr motionVector)
		{
			return vtkTensorProbeRepresentation.vtkTensorProbeRepresentation_Move_12(base.GetCppThis(), motionVector);
		}

		// Token: 0x06008D75 RID: 36213
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkTensorProbeRepresentation_NewInstance_13(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Standard methods for instances of this class.
		/// </summary>
		// Token: 0x06008D76 RID: 36214 RVA: 0x000C9A08 File Offset: 0x000C7C08
		public new vtkTensorProbeRepresentation NewInstance()
		{
			vtkTensorProbeRepresentation result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkTensorProbeRepresentation.vtkTensorProbeRepresentation_NewInstance_13(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkTensorProbeRepresentation)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x06008D77 RID: 36215
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkTensorProbeRepresentation_ReleaseGraphicsResources_14(HandleRef pThis, HandleRef arg0);

		/// <summary>
		/// See vtkProp for details.
		/// </summary>
		// Token: 0x06008D78 RID: 36216 RVA: 0x000C9A64 File Offset: 0x000C7C64
		public override void ReleaseGraphicsResources(vtkWindow arg0)
		{
			vtkTensorProbeRepresentation.vtkTensorProbeRepresentation_ReleaseGraphicsResources_14(base.GetCppThis(), (arg0 == null) ? default(HandleRef) : arg0.GetCppThis());
		}

		// Token: 0x06008D79 RID: 36217
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkTensorProbeRepresentation_RenderOpaqueGeometry_15(HandleRef pThis, HandleRef arg0);

		/// <summary>
		/// See vtkWidgetRepresentation for details.
		/// </summary>
		// Token: 0x06008D7A RID: 36218 RVA: 0x000C9A94 File Offset: 0x000C7C94
		public override int RenderOpaqueGeometry(vtkViewport arg0)
		{
			return vtkTensorProbeRepresentation.vtkTensorProbeRepresentation_RenderOpaqueGeometry_15(base.GetCppThis(), (arg0 == null) ? default(HandleRef) : arg0.GetCppThis());
		}

		// Token: 0x06008D7B RID: 36219
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkTensorProbeRepresentation_SafeDownCast_16(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Standard methods for instances of this class.
		/// </summary>
		// Token: 0x06008D7C RID: 36220 RVA: 0x000C9AC8 File Offset: 0x000C7CC8
		public new static vtkTensorProbeRepresentation SafeDownCast(vtkObjectBase o)
		{
			vtkTensorProbeRepresentation vtkTensorProbeRepresentation = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkTensorProbeRepresentation.vtkTensorProbeRepresentation_SafeDownCast_16((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkTensorProbeRepresentation = (vtkTensorProbeRepresentation)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkTensorProbeRepresentation.Register(null);
				}
			}
			return vtkTensorProbeRepresentation;
		}

		// Token: 0x06008D7D RID: 36221
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkTensorProbeRepresentation_SelectProbe_17(HandleRef pThis, IntPtr pos);

		/// <summary>
		/// This method is invoked by the widget during user interaction.
		/// Can we pick the tensor glyph at the current cursor pos
		/// </summary>
		// Token: 0x06008D7E RID: 36222 RVA: 0x000C9B48 File Offset: 0x000C7D48
		public virtual int SelectProbe(IntPtr pos)
		{
			return vtkTensorProbeRepresentation.vtkTensorProbeRepresentation_SelectProbe_17(base.GetCppThis(), pos);
		}

		// Token: 0x06008D7F RID: 36223
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkTensorProbeRepresentation_SetProbeCellId_18(HandleRef pThis, long _arg);

		/// <summary>
		/// Set the position of the Tensor probe.
		/// </summary>
		// Token: 0x06008D80 RID: 36224 RVA: 0x000C9B68 File Offset: 0x000C7D68
		public virtual void SetProbeCellId(long _arg)
		{
			vtkTensorProbeRepresentation.vtkTensorProbeRepresentation_SetProbeCellId_18(base.GetCppThis(), _arg);
		}

		// Token: 0x06008D81 RID: 36225
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkTensorProbeRepresentation_SetProbePosition_19(HandleRef pThis, double _arg1, double _arg2, double _arg3);

		/// <summary>
		/// Set the position of the Tensor probe.
		/// </summary>
		// Token: 0x06008D82 RID: 36226 RVA: 0x000C9B78 File Offset: 0x000C7D78
		public virtual void SetProbePosition(double _arg1, double _arg2, double _arg3)
		{
			vtkTensorProbeRepresentation.vtkTensorProbeRepresentation_SetProbePosition_19(base.GetCppThis(), _arg1, _arg2, _arg3);
		}

		// Token: 0x06008D83 RID: 36227
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkTensorProbeRepresentation_SetProbePosition_20(HandleRef pThis, IntPtr _arg);

		/// <summary>
		/// Set the position of the Tensor probe.
		/// </summary>
		// Token: 0x06008D84 RID: 36228 RVA: 0x000C9B8A File Offset: 0x000C7D8A
		public virtual void SetProbePosition(IntPtr _arg)
		{
			vtkTensorProbeRepresentation.vtkTensorProbeRepresentation_SetProbePosition_20(base.GetCppThis(), _arg);
		}

		// Token: 0x06008D85 RID: 36229
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkTensorProbeRepresentation_SetTrajectory_21(HandleRef pThis, HandleRef arg0);

		/// <summary>
		/// Set the trajectory that we are trying to probe tensors on
		/// </summary>
		// Token: 0x06008D86 RID: 36230 RVA: 0x000C9B9C File Offset: 0x000C7D9C
		public virtual void SetTrajectory(vtkPolyData arg0)
		{
			vtkTensorProbeRepresentation.vtkTensorProbeRepresentation_SetTrajectory_21(base.GetCppThis(), (arg0 == null) ? default(HandleRef) : arg0.GetCppThis());
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04000BD4 RID: 3028
		public new const string MRFullTypeName = "Kitware.VTK.vtkTensorProbeRepresentation";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04000BD5 RID: 3029
		public new static readonly string MRClassNameKey = "class vtkTensorProbeRepresentation";
	}
}
