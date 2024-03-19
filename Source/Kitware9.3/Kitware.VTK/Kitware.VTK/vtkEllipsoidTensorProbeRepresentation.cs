using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkEllipsoidTensorProbeRepresentation
	/// </summary>
	/// <remarks>
	///    A concrete implementation of vtkTensorProbeRepresentation that renders tensors as
	/// ellipoids.
	///
	/// vtkEllipsoidTensorProbeRepresentation is a concrete implementation of
	/// vtkTensorProbeRepresentation. It renders tensors as ellipsoids. Locations
	/// between two points when probed have the tensors linearly interpolated
	/// from the neighboring locations on the polyline.
	///
	/// </remarks>
	/// <seealso>
	///
	/// vtkTensorProbeWidget
	/// </seealso>
	// Token: 0x02000313 RID: 787
	public class vtkEllipsoidTensorProbeRepresentation : vtkTensorProbeRepresentation
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x06008D87 RID: 36231 RVA: 0x000C9BCB File Offset: 0x000C7DCB
		static vtkEllipsoidTensorProbeRepresentation()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkEllipsoidTensorProbeRepresentation.MRClassNameKey, Type.GetType("Kitware.VTK.vtkEllipsoidTensorProbeRepresentation"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x06008D88 RID: 36232 RVA: 0x000C9BF3 File Offset: 0x000C7DF3
		public vtkEllipsoidTensorProbeRepresentation(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x06008D89 RID: 36233
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkEllipsoidTensorProbeRepresentation_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06008D8A RID: 36234 RVA: 0x000C9C04 File Offset: 0x000C7E04
		public new static vtkEllipsoidTensorProbeRepresentation New()
		{
			vtkEllipsoidTensorProbeRepresentation result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkEllipsoidTensorProbeRepresentation.vtkEllipsoidTensorProbeRepresentation_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkEllipsoidTensorProbeRepresentation)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06008D8B RID: 36235 RVA: 0x000C9C58 File Offset: 0x000C7E58
		public vtkEllipsoidTensorProbeRepresentation() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkEllipsoidTensorProbeRepresentation.vtkEllipsoidTensorProbeRepresentation_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x06008D8C RID: 36236 RVA: 0x000C9C9C File Offset: 0x000C7E9C
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x06008D8D RID: 36237
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkEllipsoidTensorProbeRepresentation_BuildRepresentation_01(HandleRef pThis);

		/// <summary>
		/// Standard methods for instances of this class.
		/// </summary>
		// Token: 0x06008D8E RID: 36238 RVA: 0x000C9CA7 File Offset: 0x000C7EA7
		public override void BuildRepresentation()
		{
			vtkEllipsoidTensorProbeRepresentation.vtkEllipsoidTensorProbeRepresentation_BuildRepresentation_01(base.GetCppThis());
		}

		// Token: 0x06008D8F RID: 36239
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkEllipsoidTensorProbeRepresentation_GetActors_02(HandleRef pThis, HandleRef arg0);

		/// <summary>
		/// See vtkProp for details.
		/// </summary>
		// Token: 0x06008D90 RID: 36240 RVA: 0x000C9CB8 File Offset: 0x000C7EB8
		public override void GetActors(vtkPropCollection arg0)
		{
			vtkEllipsoidTensorProbeRepresentation.vtkEllipsoidTensorProbeRepresentation_GetActors_02(base.GetCppThis(), (arg0 == null) ? default(HandleRef) : arg0.GetCppThis());
		}

		// Token: 0x06008D91 RID: 36241
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkEllipsoidTensorProbeRepresentation_GetNumberOfGenerationsFromBase_03(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		/// Standard methods for instances of this class.
		/// </summary>
		// Token: 0x06008D92 RID: 36242 RVA: 0x000C9CE8 File Offset: 0x000C7EE8
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkEllipsoidTensorProbeRepresentation.vtkEllipsoidTensorProbeRepresentation_GetNumberOfGenerationsFromBase_03(base.GetCppThis(), type);
		}

		// Token: 0x06008D93 RID: 36243
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkEllipsoidTensorProbeRepresentation_GetNumberOfGenerationsFromBaseType_04([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		/// Standard methods for instances of this class.
		/// </summary>
		// Token: 0x06008D94 RID: 36244 RVA: 0x000C9D08 File Offset: 0x000C7F08
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkEllipsoidTensorProbeRepresentation.vtkEllipsoidTensorProbeRepresentation_GetNumberOfGenerationsFromBaseType_04(type);
		}

		// Token: 0x06008D95 RID: 36245
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkEllipsoidTensorProbeRepresentation_IsA_05(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		/// Standard methods for instances of this class.
		/// </summary>
		// Token: 0x06008D96 RID: 36246 RVA: 0x000C9D24 File Offset: 0x000C7F24
		public override int IsA(string type)
		{
			return vtkEllipsoidTensorProbeRepresentation.vtkEllipsoidTensorProbeRepresentation_IsA_05(base.GetCppThis(), type);
		}

		// Token: 0x06008D97 RID: 36247
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkEllipsoidTensorProbeRepresentation_IsTypeOf_06([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		/// Standard methods for instances of this class.
		/// </summary>
		// Token: 0x06008D98 RID: 36248 RVA: 0x000C9D44 File Offset: 0x000C7F44
		public new static int IsTypeOf(string type)
		{
			return vtkEllipsoidTensorProbeRepresentation.vtkEllipsoidTensorProbeRepresentation_IsTypeOf_06(type);
		}

		// Token: 0x06008D99 RID: 36249
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkEllipsoidTensorProbeRepresentation_NewInstance_08(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Standard methods for instances of this class.
		/// </summary>
		// Token: 0x06008D9A RID: 36250 RVA: 0x000C9D60 File Offset: 0x000C7F60
		public new vtkEllipsoidTensorProbeRepresentation NewInstance()
		{
			vtkEllipsoidTensorProbeRepresentation result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkEllipsoidTensorProbeRepresentation.vtkEllipsoidTensorProbeRepresentation_NewInstance_08(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkEllipsoidTensorProbeRepresentation)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x06008D9B RID: 36251
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkEllipsoidTensorProbeRepresentation_RegisterPickers_09(HandleRef pThis);

		/// <summary>
		/// See vtkProp for details.
		/// </summary>
		// Token: 0x06008D9C RID: 36252 RVA: 0x000C9DBA File Offset: 0x000C7FBA
		public override void RegisterPickers()
		{
			vtkEllipsoidTensorProbeRepresentation.vtkEllipsoidTensorProbeRepresentation_RegisterPickers_09(base.GetCppThis());
		}

		// Token: 0x06008D9D RID: 36253
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkEllipsoidTensorProbeRepresentation_ReleaseGraphicsResources_10(HandleRef pThis, HandleRef arg0);

		/// <summary>
		/// See vtkProp for details.
		/// </summary>
		// Token: 0x06008D9E RID: 36254 RVA: 0x000C9DCC File Offset: 0x000C7FCC
		public override void ReleaseGraphicsResources(vtkWindow arg0)
		{
			vtkEllipsoidTensorProbeRepresentation.vtkEllipsoidTensorProbeRepresentation_ReleaseGraphicsResources_10(base.GetCppThis(), (arg0 == null) ? default(HandleRef) : arg0.GetCppThis());
		}

		// Token: 0x06008D9F RID: 36255
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkEllipsoidTensorProbeRepresentation_RenderOpaqueGeometry_11(HandleRef pThis, HandleRef arg0);

		/// <summary>
		/// Standard methods for instances of this class.
		/// </summary>
		// Token: 0x06008DA0 RID: 36256 RVA: 0x000C9DFC File Offset: 0x000C7FFC
		public override int RenderOpaqueGeometry(vtkViewport arg0)
		{
			return vtkEllipsoidTensorProbeRepresentation.vtkEllipsoidTensorProbeRepresentation_RenderOpaqueGeometry_11(base.GetCppThis(), (arg0 == null) ? default(HandleRef) : arg0.GetCppThis());
		}

		// Token: 0x06008DA1 RID: 36257
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkEllipsoidTensorProbeRepresentation_SafeDownCast_12(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Standard methods for instances of this class.
		/// </summary>
		// Token: 0x06008DA2 RID: 36258 RVA: 0x000C9E30 File Offset: 0x000C8030
		public new static vtkEllipsoidTensorProbeRepresentation SafeDownCast(vtkObjectBase o)
		{
			vtkEllipsoidTensorProbeRepresentation vtkEllipsoidTensorProbeRepresentation = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkEllipsoidTensorProbeRepresentation.vtkEllipsoidTensorProbeRepresentation_SafeDownCast_12((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkEllipsoidTensorProbeRepresentation = (vtkEllipsoidTensorProbeRepresentation)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkEllipsoidTensorProbeRepresentation.Register(null);
				}
			}
			return vtkEllipsoidTensorProbeRepresentation;
		}

		// Token: 0x06008DA3 RID: 36259
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkEllipsoidTensorProbeRepresentation_SelectProbe_13(HandleRef pThis, IntPtr pos);

		/// <summary>
		/// Can we pick the tensor glyph at the current cursor pos
		/// </summary>
		// Token: 0x06008DA4 RID: 36260 RVA: 0x000C9EB0 File Offset: 0x000C80B0
		public override int SelectProbe(IntPtr pos)
		{
			return vtkEllipsoidTensorProbeRepresentation.vtkEllipsoidTensorProbeRepresentation_SelectProbe_13(base.GetCppThis(), pos);
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04000BD6 RID: 3030
		public new const string MRFullTypeName = "Kitware.VTK.vtkEllipsoidTensorProbeRepresentation";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04000BD7 RID: 3031
		public new static readonly string MRClassNameKey = "class vtkEllipsoidTensorProbeRepresentation";
	}
}
