using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkImageDivergence
	/// </summary>
	/// <remarks>
	///    Divergence of a vector field.
	///
	/// vtkImageDivergence takes a 3D vector field
	/// and creates a scalar field which
	/// which represents the rate of change of the vector field.
	/// The definition of Divergence:
	/// Given V = P(x,y,z), Q(x,y,z), R(x,y,z),
	/// Divergence = dP/dx + dQ/dy + dR/dz.
	/// </remarks>
	// Token: 0x02000252 RID: 594
	public class vtkImageDivergence : vtkThreadedImageAlgorithm
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x06006E0E RID: 28174 RVA: 0x0009EA98 File Offset: 0x0009CC98
		static vtkImageDivergence()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkImageDivergence.MRClassNameKey, Type.GetType("Kitware.VTK.vtkImageDivergence"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x06006E0F RID: 28175 RVA: 0x0009EAC0 File Offset: 0x0009CCC0
		public vtkImageDivergence(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x06006E10 RID: 28176
		[DllImport("Kitware.VTK.ImagingMath.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkImageDivergence_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06006E11 RID: 28177 RVA: 0x0009EAD0 File Offset: 0x0009CCD0
		public new static vtkImageDivergence New()
		{
			vtkImageDivergence result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkImageDivergence.vtkImageDivergence_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkImageDivergence)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06006E12 RID: 28178 RVA: 0x0009EB24 File Offset: 0x0009CD24
		public vtkImageDivergence() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkImageDivergence.vtkImageDivergence_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x06006E13 RID: 28179 RVA: 0x0009EB68 File Offset: 0x0009CD68
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x06006E14 RID: 28180
		[DllImport("Kitware.VTK.ImagingMath.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkImageDivergence_GetNumberOfGenerationsFromBase_01(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06006E15 RID: 28181 RVA: 0x0009EB74 File Offset: 0x0009CD74
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkImageDivergence.vtkImageDivergence_GetNumberOfGenerationsFromBase_01(base.GetCppThis(), type);
		}

		// Token: 0x06006E16 RID: 28182
		[DllImport("Kitware.VTK.ImagingMath.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkImageDivergence_GetNumberOfGenerationsFromBaseType_02([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06006E17 RID: 28183 RVA: 0x0009EB94 File Offset: 0x0009CD94
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkImageDivergence.vtkImageDivergence_GetNumberOfGenerationsFromBaseType_02(type);
		}

		// Token: 0x06006E18 RID: 28184
		[DllImport("Kitware.VTK.ImagingMath.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkImageDivergence_IsA_03(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06006E19 RID: 28185 RVA: 0x0009EBB0 File Offset: 0x0009CDB0
		public override int IsA(string type)
		{
			return vtkImageDivergence.vtkImageDivergence_IsA_03(base.GetCppThis(), type);
		}

		// Token: 0x06006E1A RID: 28186
		[DllImport("Kitware.VTK.ImagingMath.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkImageDivergence_IsTypeOf_04([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06006E1B RID: 28187 RVA: 0x0009EBD0 File Offset: 0x0009CDD0
		public new static int IsTypeOf(string type)
		{
			return vtkImageDivergence.vtkImageDivergence_IsTypeOf_04(type);
		}

		// Token: 0x06006E1C RID: 28188
		[DllImport("Kitware.VTK.ImagingMath.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkImageDivergence_NewInstance_06(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06006E1D RID: 28189 RVA: 0x0009EBEC File Offset: 0x0009CDEC
		public new vtkImageDivergence NewInstance()
		{
			vtkImageDivergence result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkImageDivergence.vtkImageDivergence_NewInstance_06(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkImageDivergence)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x06006E1E RID: 28190
		[DllImport("Kitware.VTK.ImagingMath.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkImageDivergence_SafeDownCast_07(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06006E1F RID: 28191 RVA: 0x0009EC48 File Offset: 0x0009CE48
		public new static vtkImageDivergence SafeDownCast(vtkObjectBase o)
		{
			vtkImageDivergence vtkImageDivergence = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkImageDivergence.vtkImageDivergence_SafeDownCast_07((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkImageDivergence = (vtkImageDivergence)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkImageDivergence.Register(null);
				}
			}
			return vtkImageDivergence;
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04000999 RID: 2457
		public new const string MRFullTypeName = "Kitware.VTK.vtkImageDivergence";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x0400099A RID: 2458
		public new static readonly string MRClassNameKey = "class vtkImageDivergence";
	}
}
