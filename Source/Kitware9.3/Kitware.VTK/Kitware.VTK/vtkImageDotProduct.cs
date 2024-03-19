using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkImageDotProduct
	/// </summary>
	/// <remarks>
	///    Dot product of two vector images.
	///
	/// vtkImageDotProduct interprets the scalar components of two images
	/// as vectors and takes the dot product vector by vector (pixel by pixel).
	/// </remarks>
	// Token: 0x02000253 RID: 595
	public class vtkImageDotProduct : vtkThreadedImageAlgorithm
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x06006E20 RID: 28192 RVA: 0x0009ECC7 File Offset: 0x0009CEC7
		static vtkImageDotProduct()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkImageDotProduct.MRClassNameKey, Type.GetType("Kitware.VTK.vtkImageDotProduct"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x06006E21 RID: 28193 RVA: 0x0009ECEF File Offset: 0x0009CEEF
		public vtkImageDotProduct(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x06006E22 RID: 28194
		[DllImport("Kitware.VTK.ImagingMath.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkImageDotProduct_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06006E23 RID: 28195 RVA: 0x0009ED00 File Offset: 0x0009CF00
		public new static vtkImageDotProduct New()
		{
			vtkImageDotProduct result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkImageDotProduct.vtkImageDotProduct_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkImageDotProduct)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06006E24 RID: 28196 RVA: 0x0009ED54 File Offset: 0x0009CF54
		public vtkImageDotProduct() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkImageDotProduct.vtkImageDotProduct_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x06006E25 RID: 28197 RVA: 0x0009ED98 File Offset: 0x0009CF98
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x06006E26 RID: 28198
		[DllImport("Kitware.VTK.ImagingMath.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkImageDotProduct_GetNumberOfGenerationsFromBase_01(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06006E27 RID: 28199 RVA: 0x0009EDA4 File Offset: 0x0009CFA4
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkImageDotProduct.vtkImageDotProduct_GetNumberOfGenerationsFromBase_01(base.GetCppThis(), type);
		}

		// Token: 0x06006E28 RID: 28200
		[DllImport("Kitware.VTK.ImagingMath.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkImageDotProduct_GetNumberOfGenerationsFromBaseType_02([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06006E29 RID: 28201 RVA: 0x0009EDC4 File Offset: 0x0009CFC4
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkImageDotProduct.vtkImageDotProduct_GetNumberOfGenerationsFromBaseType_02(type);
		}

		// Token: 0x06006E2A RID: 28202
		[DllImport("Kitware.VTK.ImagingMath.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkImageDotProduct_IsA_03(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06006E2B RID: 28203 RVA: 0x0009EDE0 File Offset: 0x0009CFE0
		public override int IsA(string type)
		{
			return vtkImageDotProduct.vtkImageDotProduct_IsA_03(base.GetCppThis(), type);
		}

		// Token: 0x06006E2C RID: 28204
		[DllImport("Kitware.VTK.ImagingMath.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkImageDotProduct_IsTypeOf_04([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06006E2D RID: 28205 RVA: 0x0009EE00 File Offset: 0x0009D000
		public new static int IsTypeOf(string type)
		{
			return vtkImageDotProduct.vtkImageDotProduct_IsTypeOf_04(type);
		}

		// Token: 0x06006E2E RID: 28206
		[DllImport("Kitware.VTK.ImagingMath.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkImageDotProduct_NewInstance_06(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06006E2F RID: 28207 RVA: 0x0009EE1C File Offset: 0x0009D01C
		public new vtkImageDotProduct NewInstance()
		{
			vtkImageDotProduct result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkImageDotProduct.vtkImageDotProduct_NewInstance_06(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkImageDotProduct)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x06006E30 RID: 28208
		[DllImport("Kitware.VTK.ImagingMath.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkImageDotProduct_SafeDownCast_07(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06006E31 RID: 28209 RVA: 0x0009EE78 File Offset: 0x0009D078
		public new static vtkImageDotProduct SafeDownCast(vtkObjectBase o)
		{
			vtkImageDotProduct vtkImageDotProduct = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkImageDotProduct.vtkImageDotProduct_SafeDownCast_07((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkImageDotProduct = (vtkImageDotProduct)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkImageDotProduct.Register(null);
				}
			}
			return vtkImageDotProduct;
		}

		// Token: 0x06006E32 RID: 28210
		[DllImport("Kitware.VTK.ImagingMath.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImageDotProduct_SetInput1Data_08(HandleRef pThis, HandleRef arg0);

		/// <summary>
		/// Set the two inputs to this filter
		/// </summary>
		// Token: 0x06006E33 RID: 28211 RVA: 0x0009EEF8 File Offset: 0x0009D0F8
		public virtual void SetInput1Data(vtkDataObject arg0)
		{
			vtkImageDotProduct.vtkImageDotProduct_SetInput1Data_08(base.GetCppThis(), (arg0 == null) ? default(HandleRef) : arg0.GetCppThis());
		}

		// Token: 0x06006E34 RID: 28212
		[DllImport("Kitware.VTK.ImagingMath.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImageDotProduct_SetInput2Data_09(HandleRef pThis, HandleRef arg0);

		/// <summary>
		/// Set the two inputs to this filter
		/// </summary>
		// Token: 0x06006E35 RID: 28213 RVA: 0x0009EF28 File Offset: 0x0009D128
		public virtual void SetInput2Data(vtkDataObject arg0)
		{
			vtkImageDotProduct.vtkImageDotProduct_SetInput2Data_09(base.GetCppThis(), (arg0 == null) ? default(HandleRef) : arg0.GetCppThis());
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x0400099B RID: 2459
		public new const string MRFullTypeName = "Kitware.VTK.vtkImageDotProduct";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x0400099C RID: 2460
		public new static readonly string MRClassNameKey = "class vtkImageDotProduct";
	}
}
