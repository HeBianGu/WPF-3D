using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkGaussianCubeReader
	/// </summary>
	/// <remarks>
	///    read ASCII Gaussian Cube Data files
	///
	/// vtkGaussianCubeReader is a source object that reads ASCII files following
	/// the description in http://www.gaussian.com/00000430.htm
	/// The FileName must be specified.
	///
	/// @par Thanks:
	/// Dr. Jean M. Favre who developed and contributed this class.
	/// </remarks>
	// Token: 0x020001CE RID: 462
	public class vtkGaussianCubeReader : vtkMoleculeReaderBase
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x0600596C RID: 22892 RVA: 0x00081187 File Offset: 0x0007F387
		static vtkGaussianCubeReader()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkGaussianCubeReader.MRClassNameKey, Type.GetType("Kitware.VTK.vtkGaussianCubeReader"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x0600596D RID: 22893 RVA: 0x000811AF File Offset: 0x0007F3AF
		public vtkGaussianCubeReader(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x0600596E RID: 22894
		[DllImport("Kitware.VTK.IOChemistry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkGaussianCubeReader_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600596F RID: 22895 RVA: 0x000811C0 File Offset: 0x0007F3C0
		public new static vtkGaussianCubeReader New()
		{
			vtkGaussianCubeReader result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkGaussianCubeReader.vtkGaussianCubeReader_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkGaussianCubeReader)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06005970 RID: 22896 RVA: 0x00081214 File Offset: 0x0007F414
		public vtkGaussianCubeReader() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkGaussianCubeReader.vtkGaussianCubeReader_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x06005971 RID: 22897 RVA: 0x00081258 File Offset: 0x0007F458
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x06005972 RID: 22898
		[DllImport("Kitware.VTK.IOChemistry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkGaussianCubeReader_GetGridOutput_01(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06005973 RID: 22899 RVA: 0x00081264 File Offset: 0x0007F464
		public vtkImageData GetGridOutput()
		{
			vtkImageData vtkImageData = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkGaussianCubeReader.vtkGaussianCubeReader_GetGridOutput_01(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkImageData = (vtkImageData)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkImageData.Register(null);
				}
			}
			return vtkImageData;
		}

		// Token: 0x06005974 RID: 22900
		[DllImport("Kitware.VTK.IOChemistry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkGaussianCubeReader_GetNumberOfGenerationsFromBase_02(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06005975 RID: 22901 RVA: 0x000812D4 File Offset: 0x0007F4D4
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkGaussianCubeReader.vtkGaussianCubeReader_GetNumberOfGenerationsFromBase_02(base.GetCppThis(), type);
		}

		// Token: 0x06005976 RID: 22902
		[DllImport("Kitware.VTK.IOChemistry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkGaussianCubeReader_GetNumberOfGenerationsFromBaseType_03([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06005977 RID: 22903 RVA: 0x000812F4 File Offset: 0x0007F4F4
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkGaussianCubeReader.vtkGaussianCubeReader_GetNumberOfGenerationsFromBaseType_03(type);
		}

		// Token: 0x06005978 RID: 22904
		[DllImport("Kitware.VTK.IOChemistry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkGaussianCubeReader_GetTransform_04(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06005979 RID: 22905 RVA: 0x00081310 File Offset: 0x0007F510
		public virtual vtkTransform GetTransform()
		{
			vtkTransform vtkTransform = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkGaussianCubeReader.vtkGaussianCubeReader_GetTransform_04(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkTransform = (vtkTransform)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkTransform.Register(null);
				}
			}
			return vtkTransform;
		}

		// Token: 0x0600597A RID: 22906
		[DllImport("Kitware.VTK.IOChemistry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkGaussianCubeReader_IsA_05(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600597B RID: 22907 RVA: 0x00081380 File Offset: 0x0007F580
		public override int IsA(string type)
		{
			return vtkGaussianCubeReader.vtkGaussianCubeReader_IsA_05(base.GetCppThis(), type);
		}

		// Token: 0x0600597C RID: 22908
		[DllImport("Kitware.VTK.IOChemistry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkGaussianCubeReader_IsTypeOf_06([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600597D RID: 22909 RVA: 0x000813A0 File Offset: 0x0007F5A0
		public new static int IsTypeOf(string type)
		{
			return vtkGaussianCubeReader.vtkGaussianCubeReader_IsTypeOf_06(type);
		}

		// Token: 0x0600597E RID: 22910
		[DllImport("Kitware.VTK.IOChemistry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkGaussianCubeReader_NewInstance_08(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600597F RID: 22911 RVA: 0x000813BC File Offset: 0x0007F5BC
		public new vtkGaussianCubeReader NewInstance()
		{
			vtkGaussianCubeReader result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkGaussianCubeReader.vtkGaussianCubeReader_NewInstance_08(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkGaussianCubeReader)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x06005980 RID: 22912
		[DllImport("Kitware.VTK.IOChemistry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkGaussianCubeReader_SafeDownCast_09(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06005981 RID: 22913 RVA: 0x00081418 File Offset: 0x0007F618
		public new static vtkGaussianCubeReader SafeDownCast(vtkObjectBase o)
		{
			vtkGaussianCubeReader vtkGaussianCubeReader = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkGaussianCubeReader.vtkGaussianCubeReader_SafeDownCast_09((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkGaussianCubeReader = (vtkGaussianCubeReader)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkGaussianCubeReader.Register(null);
				}
			}
			return vtkGaussianCubeReader;
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04000863 RID: 2147
		public new const string MRFullTypeName = "Kitware.VTK.vtkGaussianCubeReader";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04000864 RID: 2148
		public new static readonly string MRClassNameKey = "class vtkGaussianCubeReader";
	}
}
