using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkQuadratureSchemeDictionaryGenerator
	///
	///
	/// Given an unstructured grid on its input this filter generates
	/// for each data array in point data dictionary (ie an instance of
	/// vtkInformationQuadratureSchemeDefinitionVectorKey). This filter
	/// has been introduced to facilitate testing of the vtkQuadrature*
	/// classes as these cannot operate with the dictionary. This class
	/// is for testing and should not be used for application development.
	///
	/// </summary>
	/// <seealso>
	///
	/// vtkQuadraturePointInterpolator, vtkQuadraturePointsGenerator, vtkQuadratureSchemeDefinition
	/// </seealso>
	// Token: 0x020008D0 RID: 2256
	public class vtkQuadratureSchemeDictionaryGenerator : vtkDataSetAlgorithm
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x060174A7 RID: 95399 RVA: 0x0020B6B7 File Offset: 0x002098B7
		static vtkQuadratureSchemeDictionaryGenerator()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkQuadratureSchemeDictionaryGenerator.MRClassNameKey, Type.GetType("Kitware.VTK.vtkQuadratureSchemeDictionaryGenerator"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x060174A8 RID: 95400 RVA: 0x0020B6DF File Offset: 0x002098DF
		public vtkQuadratureSchemeDictionaryGenerator(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x060174A9 RID: 95401
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkQuadratureSchemeDictionaryGenerator_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060174AA RID: 95402 RVA: 0x0020B6F0 File Offset: 0x002098F0
		public new static vtkQuadratureSchemeDictionaryGenerator New()
		{
			vtkQuadratureSchemeDictionaryGenerator result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkQuadratureSchemeDictionaryGenerator.vtkQuadratureSchemeDictionaryGenerator_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkQuadratureSchemeDictionaryGenerator)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060174AB RID: 95403 RVA: 0x0020B744 File Offset: 0x00209944
		public vtkQuadratureSchemeDictionaryGenerator() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkQuadratureSchemeDictionaryGenerator.vtkQuadratureSchemeDictionaryGenerator_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x060174AC RID: 95404 RVA: 0x0020B788 File Offset: 0x00209988
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x060174AD RID: 95405
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkQuadratureSchemeDictionaryGenerator_GetNumberOfGenerationsFromBase_01(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060174AE RID: 95406 RVA: 0x0020B794 File Offset: 0x00209994
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkQuadratureSchemeDictionaryGenerator.vtkQuadratureSchemeDictionaryGenerator_GetNumberOfGenerationsFromBase_01(base.GetCppThis(), type);
		}

		// Token: 0x060174AF RID: 95407
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkQuadratureSchemeDictionaryGenerator_GetNumberOfGenerationsFromBaseType_02([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060174B0 RID: 95408 RVA: 0x0020B7B4 File Offset: 0x002099B4
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkQuadratureSchemeDictionaryGenerator.vtkQuadratureSchemeDictionaryGenerator_GetNumberOfGenerationsFromBaseType_02(type);
		}

		// Token: 0x060174B1 RID: 95409
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkQuadratureSchemeDictionaryGenerator_IsA_03(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060174B2 RID: 95410 RVA: 0x0020B7D0 File Offset: 0x002099D0
		public override int IsA(string type)
		{
			return vtkQuadratureSchemeDictionaryGenerator.vtkQuadratureSchemeDictionaryGenerator_IsA_03(base.GetCppThis(), type);
		}

		// Token: 0x060174B3 RID: 95411
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkQuadratureSchemeDictionaryGenerator_IsTypeOf_04([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060174B4 RID: 95412 RVA: 0x0020B7F0 File Offset: 0x002099F0
		public new static int IsTypeOf(string type)
		{
			return vtkQuadratureSchemeDictionaryGenerator.vtkQuadratureSchemeDictionaryGenerator_IsTypeOf_04(type);
		}

		// Token: 0x060174B5 RID: 95413
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkQuadratureSchemeDictionaryGenerator_NewInstance_06(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060174B6 RID: 95414 RVA: 0x0020B80C File Offset: 0x00209A0C
		public new vtkQuadratureSchemeDictionaryGenerator NewInstance()
		{
			vtkQuadratureSchemeDictionaryGenerator result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkQuadratureSchemeDictionaryGenerator.vtkQuadratureSchemeDictionaryGenerator_NewInstance_06(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkQuadratureSchemeDictionaryGenerator)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x060174B7 RID: 95415
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkQuadratureSchemeDictionaryGenerator_SafeDownCast_07(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060174B8 RID: 95416 RVA: 0x0020B868 File Offset: 0x00209A68
		public new static vtkQuadratureSchemeDictionaryGenerator SafeDownCast(vtkObjectBase o)
		{
			vtkQuadratureSchemeDictionaryGenerator vtkQuadratureSchemeDictionaryGenerator = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkQuadratureSchemeDictionaryGenerator.vtkQuadratureSchemeDictionaryGenerator_SafeDownCast_07((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkQuadratureSchemeDictionaryGenerator = (vtkQuadratureSchemeDictionaryGenerator)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkQuadratureSchemeDictionaryGenerator.Register(null);
				}
			}
			return vtkQuadratureSchemeDictionaryGenerator;
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001A13 RID: 6675
		public new const string MRFullTypeName = "Kitware.VTK.vtkQuadratureSchemeDictionaryGenerator";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001A14 RID: 6676
		public new static readonly string MRClassNameKey = "class vtkQuadratureSchemeDictionaryGenerator";
	}
}
