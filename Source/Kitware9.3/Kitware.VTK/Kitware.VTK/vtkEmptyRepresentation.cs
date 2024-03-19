using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkEmptyRepresentation
	///
	///
	/// </summary>
	// Token: 0x020002A7 RID: 679
	public class vtkEmptyRepresentation : vtkDataRepresentation
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x06007A22 RID: 31266 RVA: 0x000B0143 File Offset: 0x000AE343
		static vtkEmptyRepresentation()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkEmptyRepresentation.MRClassNameKey, Type.GetType("Kitware.VTK.vtkEmptyRepresentation"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x06007A23 RID: 31267 RVA: 0x000B016B File Offset: 0x000AE36B
		public vtkEmptyRepresentation(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x06007A24 RID: 31268
		[DllImport("Kitware.VTK.ViewsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkEmptyRepresentation_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06007A25 RID: 31269 RVA: 0x000B017C File Offset: 0x000AE37C
		public new static vtkEmptyRepresentation New()
		{
			vtkEmptyRepresentation result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkEmptyRepresentation.vtkEmptyRepresentation_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkEmptyRepresentation)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06007A26 RID: 31270 RVA: 0x000B01D0 File Offset: 0x000AE3D0
		public vtkEmptyRepresentation() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkEmptyRepresentation.vtkEmptyRepresentation_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x06007A27 RID: 31271 RVA: 0x000B0214 File Offset: 0x000AE414
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x06007A28 RID: 31272
		[DllImport("Kitware.VTK.ViewsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkEmptyRepresentation_GetInternalAnnotationOutputPort_01(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Since this representation has no inputs, override superclass
		/// implementation with one that ignores "port" and "conn" and still allows it
		/// to have an annotation output.
		/// </summary>
		// Token: 0x06007A29 RID: 31273 RVA: 0x000B0220 File Offset: 0x000AE420
		public override vtkAlgorithmOutput GetInternalAnnotationOutputPort()
		{
			vtkAlgorithmOutput vtkAlgorithmOutput = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkEmptyRepresentation.vtkEmptyRepresentation_GetInternalAnnotationOutputPort_01(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkAlgorithmOutput = (vtkAlgorithmOutput)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkAlgorithmOutput.Register(null);
				}
			}
			return vtkAlgorithmOutput;
		}

		// Token: 0x06007A2A RID: 31274
		[DllImport("Kitware.VTK.ViewsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkEmptyRepresentation_GetInternalAnnotationOutputPort_02(HandleRef pThis, int port, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Since this representation has no inputs, override superclass
		/// implementation with one that ignores "port" and "conn" and still allows it
		/// to have an annotation output.
		/// </summary>
		// Token: 0x06007A2B RID: 31275 RVA: 0x000B0290 File Offset: 0x000AE490
		public override vtkAlgorithmOutput GetInternalAnnotationOutputPort(int port)
		{
			vtkAlgorithmOutput vtkAlgorithmOutput = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkEmptyRepresentation.vtkEmptyRepresentation_GetInternalAnnotationOutputPort_02(base.GetCppThis(), port, ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkAlgorithmOutput = (vtkAlgorithmOutput)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkAlgorithmOutput.Register(null);
				}
			}
			return vtkAlgorithmOutput;
		}

		// Token: 0x06007A2C RID: 31276
		[DllImport("Kitware.VTK.ViewsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkEmptyRepresentation_GetInternalAnnotationOutputPort_03(HandleRef pThis, int port, int conn, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Since this representation has no inputs, override superclass
		/// implementation with one that ignores "port" and "conn" and still allows it
		/// to have an annotation output.
		/// </summary>
		// Token: 0x06007A2D RID: 31277 RVA: 0x000B0300 File Offset: 0x000AE500
		public override vtkAlgorithmOutput GetInternalAnnotationOutputPort(int port, int conn)
		{
			vtkAlgorithmOutput vtkAlgorithmOutput = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkEmptyRepresentation.vtkEmptyRepresentation_GetInternalAnnotationOutputPort_03(base.GetCppThis(), port, conn, ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkAlgorithmOutput = (vtkAlgorithmOutput)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkAlgorithmOutput.Register(null);
				}
			}
			return vtkAlgorithmOutput;
		}

		// Token: 0x06007A2E RID: 31278
		[DllImport("Kitware.VTK.ViewsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkEmptyRepresentation_GetNumberOfGenerationsFromBase_04(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06007A2F RID: 31279 RVA: 0x000B0374 File Offset: 0x000AE574
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkEmptyRepresentation.vtkEmptyRepresentation_GetNumberOfGenerationsFromBase_04(base.GetCppThis(), type);
		}

		// Token: 0x06007A30 RID: 31280
		[DllImport("Kitware.VTK.ViewsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkEmptyRepresentation_GetNumberOfGenerationsFromBaseType_05([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06007A31 RID: 31281 RVA: 0x000B0394 File Offset: 0x000AE594
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkEmptyRepresentation.vtkEmptyRepresentation_GetNumberOfGenerationsFromBaseType_05(type);
		}

		// Token: 0x06007A32 RID: 31282
		[DllImport("Kitware.VTK.ViewsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkEmptyRepresentation_IsA_06(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06007A33 RID: 31283 RVA: 0x000B03B0 File Offset: 0x000AE5B0
		public override int IsA(string type)
		{
			return vtkEmptyRepresentation.vtkEmptyRepresentation_IsA_06(base.GetCppThis(), type);
		}

		// Token: 0x06007A34 RID: 31284
		[DllImport("Kitware.VTK.ViewsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkEmptyRepresentation_IsTypeOf_07([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06007A35 RID: 31285 RVA: 0x000B03D0 File Offset: 0x000AE5D0
		public new static int IsTypeOf(string type)
		{
			return vtkEmptyRepresentation.vtkEmptyRepresentation_IsTypeOf_07(type);
		}

		// Token: 0x06007A36 RID: 31286
		[DllImport("Kitware.VTK.ViewsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkEmptyRepresentation_NewInstance_09(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06007A37 RID: 31287 RVA: 0x000B03EC File Offset: 0x000AE5EC
		public new vtkEmptyRepresentation NewInstance()
		{
			vtkEmptyRepresentation result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkEmptyRepresentation.vtkEmptyRepresentation_NewInstance_09(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkEmptyRepresentation)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x06007A38 RID: 31288
		[DllImport("Kitware.VTK.ViewsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkEmptyRepresentation_SafeDownCast_10(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06007A39 RID: 31289 RVA: 0x000B0448 File Offset: 0x000AE648
		public new static vtkEmptyRepresentation SafeDownCast(vtkObjectBase o)
		{
			vtkEmptyRepresentation vtkEmptyRepresentation = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkEmptyRepresentation.vtkEmptyRepresentation_SafeDownCast_10((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkEmptyRepresentation = (vtkEmptyRepresentation)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkEmptyRepresentation.Register(null);
				}
			}
			return vtkEmptyRepresentation;
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04000A5E RID: 2654
		public new const string MRFullTypeName = "Kitware.VTK.vtkEmptyRepresentation";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04000A5F RID: 2655
		public new static readonly string MRClassNameKey = "class vtkEmptyRepresentation";
	}
}
