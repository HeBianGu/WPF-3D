using System;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Text;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkGaussianCubeReader2
	/// </summary>
	/// <remarks>
	///    Read a Gaussian Cube file and output a
	/// vtkMolecule object and a vtkImageData
	///
	///
	/// @par Thanks:
	/// Dr. Jean M. Favre who developed and contributed this class.
	/// </remarks>
	// Token: 0x020001CF RID: 463
	public class vtkGaussianCubeReader2 : vtkMoleculeAlgorithm
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x06005982 RID: 22914 RVA: 0x00081497 File Offset: 0x0007F697
		static vtkGaussianCubeReader2()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkGaussianCubeReader2.MRClassNameKey, Type.GetType("Kitware.VTK.vtkGaussianCubeReader2"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x06005983 RID: 22915 RVA: 0x000814BF File Offset: 0x0007F6BF
		public vtkGaussianCubeReader2(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x06005984 RID: 22916
		[DllImport("Kitware.VTK.IOChemistry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkGaussianCubeReader2_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06005985 RID: 22917 RVA: 0x000814D0 File Offset: 0x0007F6D0
		public new static vtkGaussianCubeReader2 New()
		{
			vtkGaussianCubeReader2 result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkGaussianCubeReader2.vtkGaussianCubeReader2_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkGaussianCubeReader2)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06005986 RID: 22918 RVA: 0x00081524 File Offset: 0x0007F724
		public vtkGaussianCubeReader2() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkGaussianCubeReader2.vtkGaussianCubeReader2_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x06005987 RID: 22919 RVA: 0x00081568 File Offset: 0x0007F768
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x06005988 RID: 22920
		[DllImport("Kitware.VTK.IOChemistry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkGaussianCubeReader2_GetFileName_01(HandleRef pThis);

		/// <summary>
		/// Get/Set the name of the CML file
		/// </summary>
		// Token: 0x06005989 RID: 22921 RVA: 0x00081574 File Offset: 0x0007F774
		public virtual string GetFileName()
		{
			string s = Marshal.PtrToStringAnsi(vtkGaussianCubeReader2.vtkGaussianCubeReader2_GetFileName_01(base.GetCppThis()));
			return Encoding.UTF8.GetString(Encoding.Default.GetBytes(s));
		}

		// Token: 0x0600598A RID: 22922
		[DllImport("Kitware.VTK.IOChemistry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkGaussianCubeReader2_GetGridOutput_02(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Get/Set the output (vtkImageData) that the reader will fill
		/// </summary>
		// Token: 0x0600598B RID: 22923 RVA: 0x000815B0 File Offset: 0x0007F7B0
		public vtkImageData GetGridOutput()
		{
			vtkImageData vtkImageData = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkGaussianCubeReader2.vtkGaussianCubeReader2_GetGridOutput_02(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
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

		// Token: 0x0600598C RID: 22924
		[DllImport("Kitware.VTK.IOChemistry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkGaussianCubeReader2_GetNumberOfGenerationsFromBase_03(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600598D RID: 22925 RVA: 0x00081620 File Offset: 0x0007F820
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkGaussianCubeReader2.vtkGaussianCubeReader2_GetNumberOfGenerationsFromBase_03(base.GetCppThis(), type);
		}

		// Token: 0x0600598E RID: 22926
		[DllImport("Kitware.VTK.IOChemistry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkGaussianCubeReader2_GetNumberOfGenerationsFromBaseType_04([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600598F RID: 22927 RVA: 0x00081640 File Offset: 0x0007F840
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkGaussianCubeReader2.vtkGaussianCubeReader2_GetNumberOfGenerationsFromBaseType_04(type);
		}

		// Token: 0x06005990 RID: 22928
		[DllImport("Kitware.VTK.IOChemistry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkGaussianCubeReader2_GetOutput_05(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Get/Set the output (vtkMolecule) that the reader will fill
		/// </summary>
		// Token: 0x06005991 RID: 22929 RVA: 0x0008165C File Offset: 0x0007F85C
		public new vtkMolecule GetOutput()
		{
			vtkMolecule vtkMolecule = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkGaussianCubeReader2.vtkGaussianCubeReader2_GetOutput_05(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkMolecule = (vtkMolecule)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkMolecule.Register(null);
				}
			}
			return vtkMolecule;
		}

		// Token: 0x06005992 RID: 22930
		[DllImport("Kitware.VTK.IOChemistry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkGaussianCubeReader2_IsA_06(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06005993 RID: 22931 RVA: 0x000816CC File Offset: 0x0007F8CC
		public override int IsA(string type)
		{
			return vtkGaussianCubeReader2.vtkGaussianCubeReader2_IsA_06(base.GetCppThis(), type);
		}

		// Token: 0x06005994 RID: 22932
		[DllImport("Kitware.VTK.IOChemistry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkGaussianCubeReader2_IsTypeOf_07([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06005995 RID: 22933 RVA: 0x000816EC File Offset: 0x0007F8EC
		public new static int IsTypeOf(string type)
		{
			return vtkGaussianCubeReader2.vtkGaussianCubeReader2_IsTypeOf_07(type);
		}

		// Token: 0x06005996 RID: 22934
		[DllImport("Kitware.VTK.IOChemistry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkGaussianCubeReader2_NewInstance_09(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06005997 RID: 22935 RVA: 0x00081708 File Offset: 0x0007F908
		public new vtkGaussianCubeReader2 NewInstance()
		{
			vtkGaussianCubeReader2 result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkGaussianCubeReader2.vtkGaussianCubeReader2_NewInstance_09(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkGaussianCubeReader2)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x06005998 RID: 22936
		[DllImport("Kitware.VTK.IOChemistry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkGaussianCubeReader2_SafeDownCast_10(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06005999 RID: 22937 RVA: 0x00081764 File Offset: 0x0007F964
		public new static vtkGaussianCubeReader2 SafeDownCast(vtkObjectBase o)
		{
			vtkGaussianCubeReader2 vtkGaussianCubeReader = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkGaussianCubeReader2.vtkGaussianCubeReader2_SafeDownCast_10((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkGaussianCubeReader = (vtkGaussianCubeReader2)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkGaussianCubeReader.Register(null);
				}
			}
			return vtkGaussianCubeReader;
		}

		// Token: 0x0600599A RID: 22938
		[DllImport("Kitware.VTK.IOChemistry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkGaussianCubeReader2_SetFileName_11(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string _arg);

		/// <summary>
		/// Get/Set the name of the CML file
		/// </summary>
		// Token: 0x0600599B RID: 22939 RVA: 0x000817E3 File Offset: 0x0007F9E3
		public virtual void SetFileName(string _arg)
		{
			vtkGaussianCubeReader2.vtkGaussianCubeReader2_SetFileName_11(base.GetCppThis(), _arg);
		}

		// Token: 0x0600599C RID: 22940
		[DllImport("Kitware.VTK.IOChemistry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkGaussianCubeReader2_SetOutput_12(HandleRef pThis, HandleRef arg0);

		/// <summary>
		/// Get/Set the output (vtkMolecule) that the reader will fill
		/// </summary>
		// Token: 0x0600599D RID: 22941 RVA: 0x000817F4 File Offset: 0x0007F9F4
		public override void SetOutput(vtkMolecule arg0)
		{
			vtkGaussianCubeReader2.vtkGaussianCubeReader2_SetOutput_12(base.GetCppThis(), (arg0 == null) ? default(HandleRef) : arg0.GetCppThis());
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04000865 RID: 2149
		public new const string MRFullTypeName = "Kitware.VTK.vtkGaussianCubeReader2";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04000866 RID: 2150
		public new static readonly string MRClassNameKey = "class vtkGaussianCubeReader2";
	}
}
