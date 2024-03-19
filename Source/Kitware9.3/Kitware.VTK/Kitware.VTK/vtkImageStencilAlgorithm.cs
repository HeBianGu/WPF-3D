using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkImageStencilAlgorithm
	/// </summary>
	/// <remarks>
	///    producer of vtkImageStencilData
	///
	/// vtkImageStencilAlgorithm is a superclass for filters that generate
	/// the special vtkImageStencilData type.  This data type is a special
	/// representation of a binary image that can be used as a mask by
	/// several imaging filters.
	/// </remarks>
	/// <seealso>
	///
	/// vtkImageStencilData vtkImageStencilSource
	/// </seealso>
	// Token: 0x02000236 RID: 566
	public class vtkImageStencilAlgorithm : vtkAlgorithm
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x060069D3 RID: 27091 RVA: 0x00098DDD File Offset: 0x00096FDD
		static vtkImageStencilAlgorithm()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkImageStencilAlgorithm.MRClassNameKey, Type.GetType("Kitware.VTK.vtkImageStencilAlgorithm"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x060069D4 RID: 27092 RVA: 0x00098E05 File Offset: 0x00097005
		public vtkImageStencilAlgorithm(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x060069D5 RID: 27093
		[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkImageStencilAlgorithm_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060069D6 RID: 27094 RVA: 0x00098E14 File Offset: 0x00097014
		public new static vtkImageStencilAlgorithm New()
		{
			vtkImageStencilAlgorithm result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkImageStencilAlgorithm.vtkImageStencilAlgorithm_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkImageStencilAlgorithm)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060069D7 RID: 27095 RVA: 0x00098E68 File Offset: 0x00097068
		public vtkImageStencilAlgorithm() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkImageStencilAlgorithm.vtkImageStencilAlgorithm_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x060069D8 RID: 27096 RVA: 0x00098EAC File Offset: 0x000970AC
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x060069D9 RID: 27097
		[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkImageStencilAlgorithm_GetNumberOfGenerationsFromBase_01(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060069DA RID: 27098 RVA: 0x00098EB8 File Offset: 0x000970B8
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkImageStencilAlgorithm.vtkImageStencilAlgorithm_GetNumberOfGenerationsFromBase_01(base.GetCppThis(), type);
		}

		// Token: 0x060069DB RID: 27099
		[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkImageStencilAlgorithm_GetNumberOfGenerationsFromBaseType_02([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060069DC RID: 27100 RVA: 0x00098ED8 File Offset: 0x000970D8
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkImageStencilAlgorithm.vtkImageStencilAlgorithm_GetNumberOfGenerationsFromBaseType_02(type);
		}

		// Token: 0x060069DD RID: 27101
		[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkImageStencilAlgorithm_GetOutput_03(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Get or set the output for this source.
		/// </summary>
		// Token: 0x060069DE RID: 27102 RVA: 0x00098EF4 File Offset: 0x000970F4
		public vtkImageStencilData GetOutput()
		{
			vtkImageStencilData vtkImageStencilData = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkImageStencilAlgorithm.vtkImageStencilAlgorithm_GetOutput_03(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkImageStencilData = (vtkImageStencilData)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkImageStencilData.Register(null);
				}
			}
			return vtkImageStencilData;
		}

		// Token: 0x060069DF RID: 27103
		[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkImageStencilAlgorithm_IsA_04(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060069E0 RID: 27104 RVA: 0x00098F64 File Offset: 0x00097164
		public override int IsA(string type)
		{
			return vtkImageStencilAlgorithm.vtkImageStencilAlgorithm_IsA_04(base.GetCppThis(), type);
		}

		// Token: 0x060069E1 RID: 27105
		[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkImageStencilAlgorithm_IsTypeOf_05([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060069E2 RID: 27106 RVA: 0x00098F84 File Offset: 0x00097184
		public new static int IsTypeOf(string type)
		{
			return vtkImageStencilAlgorithm.vtkImageStencilAlgorithm_IsTypeOf_05(type);
		}

		// Token: 0x060069E3 RID: 27107
		[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkImageStencilAlgorithm_NewInstance_07(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060069E4 RID: 27108 RVA: 0x00098FA0 File Offset: 0x000971A0
		public new vtkImageStencilAlgorithm NewInstance()
		{
			vtkImageStencilAlgorithm result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkImageStencilAlgorithm.vtkImageStencilAlgorithm_NewInstance_07(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkImageStencilAlgorithm)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x060069E5 RID: 27109
		[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkImageStencilAlgorithm_SafeDownCast_08(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060069E6 RID: 27110 RVA: 0x00098FFC File Offset: 0x000971FC
		public new static vtkImageStencilAlgorithm SafeDownCast(vtkObjectBase o)
		{
			vtkImageStencilAlgorithm vtkImageStencilAlgorithm = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkImageStencilAlgorithm.vtkImageStencilAlgorithm_SafeDownCast_08((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkImageStencilAlgorithm = (vtkImageStencilAlgorithm)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkImageStencilAlgorithm.Register(null);
				}
			}
			return vtkImageStencilAlgorithm;
		}

		// Token: 0x060069E7 RID: 27111
		[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImageStencilAlgorithm_SetOutput_09(HandleRef pThis, HandleRef output);

		/// <summary>
		/// Get or set the output for this source.
		/// </summary>
		// Token: 0x060069E8 RID: 27112 RVA: 0x0009907C File Offset: 0x0009727C
		public void SetOutput(vtkImageStencilData output)
		{
			vtkImageStencilAlgorithm.vtkImageStencilAlgorithm_SetOutput_09(base.GetCppThis(), (output == null) ? default(HandleRef) : output.GetCppThis());
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04000956 RID: 2390
		public new const string MRFullTypeName = "Kitware.VTK.vtkImageStencilAlgorithm";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04000957 RID: 2391
		public new static readonly string MRClassNameKey = "class vtkImageStencilAlgorithm";
	}
}
