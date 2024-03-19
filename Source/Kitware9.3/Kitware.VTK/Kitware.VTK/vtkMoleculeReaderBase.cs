using System;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Text;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkMoleculeReaderBase
	/// </summary>
	/// <remarks>
	///    Read molecular data files
	///
	/// vtkMoleculeReaderBase is a source object that reads molecule files.
	/// The FileName must be specified
	///
	/// @par Thanks:
	/// Dr. Jean M. Favre who originally developed and contributed this class
	/// Angelos Angelopoulos and Spiros Tsalikis for revisions
	/// </remarks>
	// Token: 0x020001CD RID: 461
	public abstract class vtkMoleculeReaderBase : vtkPolyDataAlgorithm
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x0600594D RID: 22861 RVA: 0x00080F07 File Offset: 0x0007F107
		static vtkMoleculeReaderBase()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkMoleculeReaderBase.MRClassNameKey, Type.GetType("Kitware.VTK.vtkMoleculeReaderBase"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x0600594E RID: 22862 RVA: 0x00080F2F File Offset: 0x0007F12F
		public vtkMoleculeReaderBase(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x0600594F RID: 22863 RVA: 0x00080F3D File Offset: 0x0007F13D
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x06005950 RID: 22864
		[DllImport("Kitware.VTK.IOChemistry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkMoleculeReaderBase_GetBScale_01(HandleRef pThis);

		/// <summary>
		/// A scaling factor to compute bonds between non-hydrogen atoms
		/// </summary>
		// Token: 0x06005951 RID: 22865 RVA: 0x00080F48 File Offset: 0x0007F148
		public virtual double GetBScale()
		{
			return vtkMoleculeReaderBase.vtkMoleculeReaderBase_GetBScale_01(base.GetCppThis());
		}

		// Token: 0x06005952 RID: 22866
		[DllImport("Kitware.VTK.IOChemistry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkMoleculeReaderBase_GetFileName_02(HandleRef pThis);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06005953 RID: 22867 RVA: 0x00080F68 File Offset: 0x0007F168
		public virtual string GetFileName()
		{
			string s = Marshal.PtrToStringAnsi(vtkMoleculeReaderBase.vtkMoleculeReaderBase_GetFileName_02(base.GetCppThis()));
			return Encoding.UTF8.GetString(Encoding.Default.GetBytes(s));
		}

		// Token: 0x06005954 RID: 22868
		[DllImport("Kitware.VTK.IOChemistry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkMoleculeReaderBase_GetHBScale_03(HandleRef pThis);

		/// <summary>
		/// A scaling factor to compute bonds with hydrogen atoms.
		/// </summary>
		// Token: 0x06005955 RID: 22869 RVA: 0x00080FA4 File Offset: 0x0007F1A4
		public virtual double GetHBScale()
		{
			return vtkMoleculeReaderBase.vtkMoleculeReaderBase_GetHBScale_03(base.GetCppThis());
		}

		// Token: 0x06005956 RID: 22870
		[DllImport("Kitware.VTK.IOChemistry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkMoleculeReaderBase_GetNumberOfAtoms_04(HandleRef pThis);

		/// <summary>
		/// Number of atoms in the molecule.
		/// </summary>
		// Token: 0x06005957 RID: 22871 RVA: 0x00080FC4 File Offset: 0x0007F1C4
		public virtual long GetNumberOfAtoms()
		{
			return vtkMoleculeReaderBase.vtkMoleculeReaderBase_GetNumberOfAtoms_04(base.GetCppThis());
		}

		// Token: 0x06005958 RID: 22872
		[DllImport("Kitware.VTK.IOChemistry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkMoleculeReaderBase_GetNumberOfGenerationsFromBase_05(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06005959 RID: 22873 RVA: 0x00080FE4 File Offset: 0x0007F1E4
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkMoleculeReaderBase.vtkMoleculeReaderBase_GetNumberOfGenerationsFromBase_05(base.GetCppThis(), type);
		}

		// Token: 0x0600595A RID: 22874
		[DllImport("Kitware.VTK.IOChemistry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkMoleculeReaderBase_GetNumberOfGenerationsFromBaseType_06([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600595B RID: 22875 RVA: 0x00081004 File Offset: 0x0007F204
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkMoleculeReaderBase.vtkMoleculeReaderBase_GetNumberOfGenerationsFromBaseType_06(type);
		}

		// Token: 0x0600595C RID: 22876
		[DllImport("Kitware.VTK.IOChemistry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern uint vtkMoleculeReaderBase_GetNumberOfModels_07(HandleRef pThis);

		/// <summary>
		/// Number of models that make up the molecule.
		/// </summary>
		// Token: 0x0600595D RID: 22877 RVA: 0x00081020 File Offset: 0x0007F220
		public virtual uint GetNumberOfModels()
		{
			return vtkMoleculeReaderBase.vtkMoleculeReaderBase_GetNumberOfModels_07(base.GetCppThis());
		}

		// Token: 0x0600595E RID: 22878
		[DllImport("Kitware.VTK.IOChemistry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkMoleculeReaderBase_IsA_08(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600595F RID: 22879 RVA: 0x00081040 File Offset: 0x0007F240
		public override int IsA(string type)
		{
			return vtkMoleculeReaderBase.vtkMoleculeReaderBase_IsA_08(base.GetCppThis(), type);
		}

		// Token: 0x06005960 RID: 22880
		[DllImport("Kitware.VTK.IOChemistry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkMoleculeReaderBase_IsTypeOf_09([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06005961 RID: 22881 RVA: 0x00081060 File Offset: 0x0007F260
		public new static int IsTypeOf(string type)
		{
			return vtkMoleculeReaderBase.vtkMoleculeReaderBase_IsTypeOf_09(type);
		}

		// Token: 0x06005962 RID: 22882
		[DllImport("Kitware.VTK.IOChemistry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkMoleculeReaderBase_NewInstance_10(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06005963 RID: 22883 RVA: 0x0008107C File Offset: 0x0007F27C
		public new vtkMoleculeReaderBase NewInstance()
		{
			vtkMoleculeReaderBase result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkMoleculeReaderBase.vtkMoleculeReaderBase_NewInstance_10(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkMoleculeReaderBase)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x06005964 RID: 22884
		[DllImport("Kitware.VTK.IOChemistry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkMoleculeReaderBase_SafeDownCast_11(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06005965 RID: 22885 RVA: 0x000810D8 File Offset: 0x0007F2D8
		public new static vtkMoleculeReaderBase SafeDownCast(vtkObjectBase o)
		{
			vtkMoleculeReaderBase vtkMoleculeReaderBase = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkMoleculeReaderBase.vtkMoleculeReaderBase_SafeDownCast_11((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkMoleculeReaderBase = (vtkMoleculeReaderBase)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkMoleculeReaderBase.Register(null);
				}
			}
			return vtkMoleculeReaderBase;
		}

		// Token: 0x06005966 RID: 22886
		[DllImport("Kitware.VTK.IOChemistry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkMoleculeReaderBase_SetBScale_12(HandleRef pThis, double _arg);

		/// <summary>
		/// A scaling factor to compute bonds between non-hydrogen atoms
		/// </summary>
		// Token: 0x06005967 RID: 22887 RVA: 0x00081157 File Offset: 0x0007F357
		public virtual void SetBScale(double _arg)
		{
			vtkMoleculeReaderBase.vtkMoleculeReaderBase_SetBScale_12(base.GetCppThis(), _arg);
		}

		// Token: 0x06005968 RID: 22888
		[DllImport("Kitware.VTK.IOChemistry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkMoleculeReaderBase_SetFileName_13(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string _arg);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06005969 RID: 22889 RVA: 0x00081167 File Offset: 0x0007F367
		public virtual void SetFileName(string _arg)
		{
			vtkMoleculeReaderBase.vtkMoleculeReaderBase_SetFileName_13(base.GetCppThis(), _arg);
		}

		// Token: 0x0600596A RID: 22890
		[DllImport("Kitware.VTK.IOChemistry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkMoleculeReaderBase_SetHBScale_14(HandleRef pThis, double _arg);

		/// <summary>
		/// A scaling factor to compute bonds with hydrogen atoms.
		/// </summary>
		// Token: 0x0600596B RID: 22891 RVA: 0x00081177 File Offset: 0x0007F377
		public virtual void SetHBScale(double _arg)
		{
			vtkMoleculeReaderBase.vtkMoleculeReaderBase_SetHBScale_14(base.GetCppThis(), _arg);
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04000861 RID: 2145
		public new const string MRFullTypeName = "Kitware.VTK.vtkMoleculeReaderBase";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04000862 RID: 2146
		public new static readonly string MRClassNameKey = "class vtkMoleculeReaderBase";
	}
}
